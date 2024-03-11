namespace Task_6_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool jatkaaLuuppi = true;

            while (jatkaaLuuppi)
            {
                // Show message box asking whether to continue looping
                DialogResult result = MessageBox.Show("Valitse YES jatkaaksesi tai NO lopettaaksesi!", "HUOM !", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    jatkaaLuuppi = true;
                }
                else
                {
                    jatkaaLuuppi = false;
                }
            }
        }
    }
}
