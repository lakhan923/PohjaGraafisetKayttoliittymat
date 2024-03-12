namespace Task_7_Array_Taulukko
{
    public partial class Form1 : Form
    {
        private int[] taulukko;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_LuoTaulukko_Click(object sender, EventArgs e)
        {
            try
            {
                int taulukkonKoko = int.Parse(textBox_TaulukonKoko.Text);
                taulukko = new int[taulukkonKoko];
                MessageBox.Show("Taulukon luominen onnistui.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating table: {ex.Message}");
            }

        }

        private void button_Talleta_Click(object sender, EventArgs e)
        {
            try
            {
                int talletettavaNumero = int.Parse(textBox_TalletettavaNumero.Text);
                int tallestuspaikanIndeksi = int.Parse(textBox_TallestuspaikanIndeksi.Text);

                if (taulukko == null || talletettavaNumero < 0 || tallestuspaikanIndeksi >= taulukko.Length)
                {
                    MessageBox.Show("Virheellistä talletus indeksiä tai taulukkoa ei ole luotu.");
                    return;
                }
                taulukko[tallestuspaikanIndeksi] = talletettavaNumero;
                MessageBox.Show($"Numero {talletettavaNumero} tallennettu talletuspaikkaan Indeksi {tallestuspaikanIndeksi}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving number: {ex.Message}");
            }

        }

        private void button_Hae_Click(object sender, EventArgs e)
        {
            try
            {
                int talletusindeksi = int.Parse(textBox_HakuTalletuspaikanIndeksi.Text);

                if (taulukko == null || talletusindeksi < 0 || talletusindeksi >= taulukko.Length)
                {
                    MessageBox.Show("Virheellistä talletus indeksiä tai taulukkoa ei ole luotu.");
                    return;
                }

                int haettuNumero = taulukko[talletusindeksi];
                textBox_HakuTulos.Text = $"{haettuNumero}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching number: {ex.Message}");
            }
        }
    }
}
