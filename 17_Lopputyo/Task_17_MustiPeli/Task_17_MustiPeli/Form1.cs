using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Numerics;

namespace Task_17_MustiPeli
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        private int gameBoardSize = 4; // Default size is 4x4
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 60;
        int countDownTime;
        bool gameOver = false;
        private bool timeUp = false;

        // variables for two-player game
        private int currentPlayer = 1;
        private int[] pairsCollected = new int[2];

        // sql connection
        private SqlConnection connection;


        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-3T1M5BE\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            LoadPictures();


            // Adding items to ComboBox programmatically
            comboBox_SelectPlayerOption.Items.Add("One Player");
            comboBox_SelectPlayerOption.Items.Add("Two Players");

            // Game Board Size ComboBox
            comboBox_GameSize.Items.Add("4x4");
            comboBox_GameSize.Items.Add("6x6");

            // Subject Area ComboBox
            comboBox_SubjectArea.Items.Add("Animals");
            comboBox_SubjectArea.Items.Add("Tools");
            comboBox_SubjectArea.Items.Add("Vegetables");
            comboBox_SubjectArea.Items.Add("Fruits");

            // Select "Fruits" by default
            comboBox_SubjectArea.SelectedItem = "Fruits";
        }


        private void TimerEvent(object sender, EventArgs e)
        {
            countDownTime--;
            label_TimeLeft.Text = "Time Left: " + countDownTime;
            if (countDownTime < 1 && !gameOver) // Check if the game is not already over
            {
                timeUp = true; // Set the timeUp flag
                GameOver("Time's Up! You Lost.");

                foreach (PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("Pics/" + (string)x.Tag + ".png");
                    }
                }
            }
        }
        private void button_Restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void LoadPictures()
        {
            int leftPosition = 20;
            int topPosition = 20;
            int rows = 0;
            int pictureBoxSize = 80; // Set the size of the PictureBoxes

            for (int i = 0; i < 16; i++) // Adjust the loop limit based on the number of PictureBoxes
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = pictureBoxSize; // Set the height
                newPic.Width = pictureBoxSize; // Set the width
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 4)
                {
                    rows++;
                    newPic.Left = leftPosition;
                    newPic.Top = topPosition;
                    this.Controls.Add(newPic);
                    leftPosition = leftPosition + pictureBoxSize + 10; // Adjust the spacing between PictureBoxes
                }

                if (rows == 4)
                {
                    leftPosition = 20;
                    topPosition += pictureBoxSize + 10; // Adjust the spacing between PictureBoxes
                    rows = 0;
                }
            }

            // Adjust the game board layout
            AdjustGameBoardLayout();
            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                // Don't register a click if the game is over
                return;
            }

            PictureBox clickedPic = sender as PictureBox;
            if (clickedPic == null)
                return;

            if (firstChoice == null)
            {
                picA = clickedPic;
                if (picA.Tag != null && picA.Image == null)
                {
                    string imagePath = LoadImagesPathForSubject((string)picA.Tag);
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        picA.Image = Image.FromFile(imagePath);
                        firstChoice = (string)picA.Tag;
                    }
                }
            }
            else if (secondChoice == null && clickedPic != picA)
            {
                picB = clickedPic;
                if (picB.Tag != null && picB.Image == null)
                {
                    string imagePath = LoadImagesPathForSubject((string)picB.Tag);
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        picB.Image = Image.FromFile(imagePath);
                        secondChoice = (string)picB.Tag;

                        CheckPictures(picA, picB);
                    }
                }
            }
        }

        private void RestartGame()
        {
            // randomize the original list
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();

            // assign the random list to the original
            numbers = randomList;
            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            tries = 0;
            label_Status.Text = "Mismatched: " + tries + " times.";
            label_TimeLeft.Text = "Time Left: " + totalTime;
            gameOver = false;
            GameTimer.Start();
            countDownTime = totalTime;

            // Reset current player and pairs collected
            currentPlayer = 1;
            pairsCollected = new int[2];

            label_CurrentPlayer.Text = "Current Player: Player 1";
            label_Player1.Text = "Player 1 Pairs: 0";
            label_Player2.Text = "Player 2 Pairs: 0";
        }

        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                A.Tag = null;
                B.Tag = null;

                // Update pairs collected for current player
                pairsCollected[currentPlayer - 1]++;
                UpdatePairsLabels();
            }
            else
            {
                tries++;
                label_Status.Text = "Mismatched: " + tries + " times.";
            }

            firstChoice = null;
            secondChoice = null;

            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            // now we are checking if all of the items have been solved
            if (pictures.All(o => o.Tag == null))
            {
                GameOver("Good Job! You Win.");
            }
            else
            {
                SwitchPlayer();
            }
        }

        private void SwitchPlayer()
        {
            if (comboBox_SelectPlayerOption.SelectedItem != null)
            {
                if (comboBox_SelectPlayerOption.SelectedItem.ToString() == "One Player")
                {
                    currentPlayer = 1; // Always use player 1 in one-player mode
                }
                else if (comboBox_SelectPlayerOption.SelectedItem.ToString() == "Two Players")
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1; // Switch between player 1 and player 2 in two-player mode
                }
            }
            UpdatePlayerLabels();
        }

        private void UpdatePlayerLabels()
        {
            label_CurrentPlayer.Text = "Current Player: Player " + currentPlayer;
            label_Player1.Text = "Player 1 Pairs: " + pairsCollected[0];
            label_Player2.Text = "Player 2 Pairs: " + pairsCollected[1];
        }

        private void UpdatePairsLabels()
        {
            label_CurrentPlayer.Text = "Current Player: Player " + currentPlayer;
            label_Player1.Text = "Player 1 Pairs: " + pairsCollected[0];
            if (pairsCollected.Length > 1)
            {
                label_Player2.Text = "Player 2 Pairs: " + pairsCollected[1];
            }
            else
            {
                label_Player2.Text = ""; // Clear label for second player if only one player is selected
            }
        }

        private void SavePlayerResult(string playerName, int score)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PlayerScores (PlayerName, Score) VALUES (@PlayerName, @Score)", connection);
                cmd.Parameters.AddWithValue("@PlayerName", playerName); 
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }


        private void GameOver(string message)
        {
            GameTimer.Stop();
            gameOver = true;

            if (!timeUp) // Check if time is not up
            {
                // Determine winner based on pairs collected
                string winner;
                if (pairsCollected[0] > pairsCollected[1])
                    winner = "Player 1";
                else if (pairsCollected[1] > pairsCollected[0])
                    winner = "Player 2";
                else
                    winner = "It's a tie";

                MessageBox.Show(message + " Winner: " + winner + ". Click Restart To Play Again.", "Game Over");

                // Save player results to the database
                int scorePlayer1 = pairsCollected[0];
                int scorePlayer2 = pairsCollected[1];

                // Ensure player names are correctly assigned
                string playerNamePlayer1 = "Player 1";
                string playerNamePlayer2 = "Player 2";

                // Pass player names and scores to SavePlayerResult method
                SavePlayerResult(playerNamePlayer1, scorePlayer1);
                SavePlayerResult(playerNamePlayer2, scorePlayer2);
            }
            else
            {
                MessageBox.Show(message, "Game Over");
            }
        }


        private void comboBox_SelectPlayerOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelectPlayerOption.SelectedItem != null)
            {
                if (comboBox_SelectPlayerOption.SelectedItem.ToString() == "One Player")
                {
                    currentPlayer = 1; // Always use player 1 in one-player mode
                }
                else if (comboBox_SelectPlayerOption.SelectedItem.ToString() == "Two Players")
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1; // Switch between player 1 and player 2 in two-player mode
                }
            }

            // Update UI to display current player and pairs collected
            UpdatePlayerLabels();

            // Reset the timer
            countDownTime = totalTime;
            label_TimeLeft.Text = "Time Left: " + countDownTime;

            // Start the timer when the player selection is made
            GameTimer.Start();
        }

        private void comboBox_GameSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the game board size based on the user's selection
            gameBoardSize = comboBox_GameSize.SelectedItem.ToString() == "4x4" ? 4 : 6;

            // Adjust the game board layout
            AdjustGameBoardLayout();

            // Restart the game
            RestartGame();

        }

        private void AdjustGameBoardLayout()
        {
            int pictureBoxSize = 80; // Set the size of the PictureBoxes
            int leftPosition = 30;
            int topPosition = 30;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Left = leftPosition + (i % gameBoardSize) * (pictureBoxSize + 10);
                pictures[i].Top = topPosition + (i / gameBoardSize) * (pictureBoxSize + 10);
            }
        }

        private void comboBox_SubjectArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load images based on the selected subject area
            string selectedSubject = comboBox_SubjectArea.SelectedItem.ToString();
            LoadImagesPathForSubject(selectedSubject);

            // Start the game if the selected subject is one of the specified subjects
            if (selectedSubject == "Animals" || selectedSubject == "Tools" || selectedSubject == "Vegetables" || selectedSubject == "Fruits")
            {
                StartGame(selectedSubject);
            }
        }

        private void StartGame(string selectedSubject)
        {
            RestartGame();
            LoadImagesPathForSubject(selectedSubject);
        }

        private string LoadImagesPathForSubject(string tag)
        {
            string subjectArea = comboBox_SubjectArea.SelectedItem.ToString();
            string imagePath = "";

            switch (subjectArea)
            {
                case "Animals":
                    imagePath = "animals/" + tag + ".png";
                    break;
                case "Tools":
                    imagePath = "tools/" + tag + ".png";
                    break;
                case "Vegetables":
                    imagePath = "vegetables/" + tag + ".png";
                    break;
                case "Fruits":
                    imagePath = "Pics/" + tag + ".png";
                    break;
                default:
                    MessageBox.Show("Selected subject area is not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return imagePath;
        }
    }
}
