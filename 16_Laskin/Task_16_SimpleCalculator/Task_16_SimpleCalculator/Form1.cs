using System.Globalization;

namespace Task_16_SimpleCalculator
{
    public partial class Form1 : Form
    {
        double firstOperand = 0;
        string currentInput = "";
        bool isCurrentOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_DisplayResult.Text == "0") || (isCurrentOperationPerformed))
                textBox_DisplayResult.Clear();

            isCurrentOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_DisplayResult.Text.Contains("."))
                    textBox_DisplayResult.Text = textBox_DisplayResult.Text + button.Text;
            }
            else
                textBox_DisplayResult.Text = textBox_DisplayResult.Text + button.Text;
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput = button.Text;
            try
            {
                // Attempt to parse the text box content into a double
                firstOperand = double.Parse(textBox_DisplayResult.Text, CultureInfo.InvariantCulture);

                // Parsing successful, proceed with operation
                textBox_DisplayResult.Text = firstOperand + " " + currentInput;
                isCurrentOperationPerformed = true;
            }
            catch (FormatException)
            {
                // Display error message for invalid input
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset calculator state
                textBox_DisplayResult.Text = "0";
                firstOperand = 0;
                currentInput = "";
            }
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            textBox_DisplayResult.Text = "0";
            firstOperand = 0;
            currentInput = "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_DisplayResult.Text = "0";
            firstOperand = 0;
            currentInput = "";
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            switch (currentInput)
            {
                case "+":
                    textBox_DisplayResult.Text = (firstOperand + double.Parse(textBox_DisplayResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    textBox_DisplayResult.Text = (firstOperand - double.Parse(textBox_DisplayResult.Text , CultureInfo.InvariantCulture)).ToString();
                    break;
                case "*":
                    textBox_DisplayResult.Text = (firstOperand * double.Parse(textBox_DisplayResult.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    double secondOperand = double.Parse(textBox_DisplayResult.Text, CultureInfo.InvariantCulture);
                    if (secondOperand != 0)
                    {
                        textBox_DisplayResult.Text = (firstOperand / secondOperand).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Reset calculator state
                        textBox_DisplayResult.Text = "0";
                        firstOperand = 0;
                        currentInput = "";
                    }
                    break;
                default:
                    break;
            }

            // Clear current input and set operation performed 
            isCurrentOperationPerformed = true;
            currentInput = "";
        }
    }
}
