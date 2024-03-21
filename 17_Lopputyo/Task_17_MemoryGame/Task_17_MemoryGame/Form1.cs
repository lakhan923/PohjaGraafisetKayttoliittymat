namespace Task_17_MemoryGame
{
    public partial class Form1 : Form
    {

        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 40;
        int countDownTime;
        bool gameOver = false;

        // variables for two-player game
        private int currentPlayer = 1;
        private int[] pairsCollected = new int[2];

        public Form1()
        {
            InitializeComponent();
            LoadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            countDownTime--;
            label_TimeLeft.Text = "Time Left: " + countDownTime;
            if (countDownTime < 1)
            {
                GameOver("Times Up! ");

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
            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                // dont register a click if the game is over
                return;
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("Pics/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            else if (secondChoice == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("Pics/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
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
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
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
            // Update pairs collected labels for both players
            label_Player1.Text = "Player 1 Pairs: " + pairsCollected[0];
            label_Player2.Text = "Player 2 Pairs: " + pairsCollected[1];
        }

        private void GameOver(string message)
        {
            GameTimer.Stop();
            gameOver = true;
            // Determine winner based on pairs collected
            string winner;
            if (pairsCollected[0] > pairsCollected[1])
                winner = "Player 1";
            else if (pairsCollected[1] > pairsCollected[0])
                winner = "Player 2";
            else
                winner = "It's a tie";

            MessageBox.Show(message + " Winner: " + winner + ". Click Restart To Play Again.", "Game Over");
        }


    }
}
