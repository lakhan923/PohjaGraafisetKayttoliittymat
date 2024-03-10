namespace Task_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            textBox_ID.ReadOnly = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Etunimi Sukunimi!");
        }

        private void btn_UusiTietue_Click(object sender, EventArgs e)
        {
            textBox_Nimi.Text = "[Syötä elukuvan nimi]";
            richTextBox_Arvio.Text = "[Kirjoita arvio tähän]";
            textBox_Kesto.Text = "0";
            textBox_Julkaisuvuosi.Text = DateTime.Now.Year.ToString();
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Nimi_Enter(object sender, EventArgs e)
        {
            if (textBox_Nimi.Text == "[Syötä elukuvan nimi]")
            {
                textBox_Nimi.Text = "";
            }
        }

        private void textBox_Nimi_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "[Syötä elokuvan nimi]";
            }
        }

        private void textBox_Kesto_Enter(object sender, EventArgs e)
        {
            if (textBox_Kesto.Text == "0")
            {
                textBox_Kesto.Text = "";
            }
        }

        private void textBox_Kesto_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0";
            }
        }

        private void richTextBox_Arvio_Enter(object sender, EventArgs e)
        {
            if (richTextBox_Arvio.Text == "[Kirjoita arvio tähän]")
            {
                richTextBox_Arvio.Text = "";
            }
        }

        private void richTextBox_Arvio_Leave(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            if (string.IsNullOrWhiteSpace(richTextBox.Text))
            {
                richTextBox.Text = "[Kirjoita arvio tähän]";
            }
        }
    }
}
