namespace Task_3_IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Tallenna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Julkaisuvuosi.Text))
            {
                MessageBox.Show("Et ole syöttänyt mitään julkaisuvuosi-kentään!");
            }
            else if (!OnkoNumero(textBox_Julkaisuvuosi.Text))
            {
                MessageBox.Show("Julkaisuvuosi ei ole numeroita!");

            }else if(string.IsNullOrWhiteSpace(textBox_Kesto.Text))
            {
                MessageBox.Show("Et ole syöttänyt mitään kesto-kentään!");
            }
            else if (!OnkoNumero(textBox_Kesto.Text))
            {
                MessageBox.Show("Kesto ei ole vain numeroita!");
            }
            else
            {
                MessageBox.Show("Check Ok!");
            }
        }

        private bool OnkoNumero(string teksti)
        {
            foreach (char merkki in teksti)
            {
                if (!char.IsDigit(merkki))
                {
                    return false;
                }
            }
            return true;
        }
    }
}