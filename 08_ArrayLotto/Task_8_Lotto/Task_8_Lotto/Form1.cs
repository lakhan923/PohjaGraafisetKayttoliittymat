namespace Task_8_Lotto
{
    public partial class Form1 : Form
    {
        private Label[] lottoNumbers;
        private Label[] lis‰Numeroa;
        private string tbDefault = "Enter 7 Numbers";

        public Form1()
        {
            InitializeComponent();
            lottoNumbers = new Label[] {Lotto1Label, Lotto2Label, Lotto3Label, Lotto4Label, Lotto5Label,
            Lotto6Label, Lotto7Label};
            lis‰Numeroa = new Label[] { lis‰Numero1Label, lis‰Numero2Label };
            UserNumbersTextBox.Text= tbDefault;
            ClearLabels();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // Generate main lottery numbers
            for (int i = 0; i < 7; i++)
            {
                lottoNumbers[i].Text = random.Next(1, 40).ToString();
            }

            // Generate additional lottery numbers
            for (int j = 0; j < 2; j++)
            {
                int number = random.Next(1, 41);
                lis‰Numeroa[j].Text = number.ToString();
            }

            // Sort and display main lottery numbers
            string mainNumbersString = GetSortedNumbersString(lottoNumbers);
            MainNumbers_Label.Text = "Main numbers: " + mainNumbersString;

            // Sort and display additional numbers
            string additionalNumbersString = GetSortedNumbersString(lis‰Numeroa);
            AdditionalNumbers_Label.Text = "Additional numbers: " + additionalNumbersString;
        }

        private string GetSortedNumbersString(Label[] labels)
        {
            int[] numbers = labels.Select(label => int.Parse(label.Text)).ToArray();
            Array.Sort(numbers);
            return string.Join(", ", numbers);
        }

        private void ClearLabels()
        {
            foreach (Label label in lottoNumbers)
            {
                label.Text = string.Empty;
            }

            foreach (Label label in lis‰Numeroa)
            {
                label.Text = string.Empty;
            }
        }

        private void CheckNumbersButton_Click(object sender, EventArgs e)
        {
            string userInput = UserNumbersTextBox.Text.Trim(); // Get user input from the single TextBox
            string[] userInputNumbers = userInput.Split(',', ' ', ';'); // Split input by comma, space, or semicolon

            if (userInputNumbers.Length != 7)
            {
                MessageBox.Show("Please enter exactly 7 numbers separated by a comma, space, or semicolon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] userNumbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                // Try parsing each extracted number
                if (int.TryParse(userInputNumbers[i], out int number))
                {
                    userNumbers[i] = number;
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers separated by a comma, space, or semicolon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Now you have the user's 7 numbers in the userNumbers array
            // Compare them with the drawn lottery numbers as before and count the matches
            int matchingNumbersCount = 0;
            foreach (int userNumber in userNumbers)
            {
                if (lottoNumbers.Select(label => int.Parse(label.Text)).Contains(userNumber))
                {
                    matchingNumbersCount++;
                }
            }

            // Display the count of matching numbers
            matchingNumbersLabel.Text = "Matching numbers: " + matchingNumbersCount;
        }

        private void UserNumbersTextBox_Enter(object sender, EventArgs e)
        {
            if (UserNumbersTextBox.Text == tbDefault)
            {
                UserNumbersTextBox.Text = "";
            }
        }
    }
}

