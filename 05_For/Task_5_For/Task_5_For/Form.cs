namespace Task_5_For
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {


            // Parse the number from the TextBox
            if (int.TryParse(textBox_Integers.Text, out int number))
            {
                // Clear the label before printing numbers
                labelNumbers.Text = "";

                // Print numbers from 1 up to the specified number
                for (int i = 1; i <= number; i++)
                {
                    // Display the current number in the label
                    labelNumbers.Text = i.ToString() + " ";

                    // Update the label to display the current number
                    labelNumbers.Refresh();

                    // Delay for 100 milliseconds
                    Thread.Sleep(100);
                }
            }
            else
            {
                // If the input is not a valid integer, display an error message
                MessageBox.Show("Please enter a valid integer number.");
            }
        }
    }
}
