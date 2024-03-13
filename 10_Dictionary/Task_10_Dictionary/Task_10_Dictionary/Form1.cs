namespace Task_10_Dictionary
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> myDictionary;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LuoDic_Click(object sender, EventArgs e)
        {
            myDictionary = new Dictionary<string, string>();
            MessageBox.Show("Dictionary created successfully!");
        }

        private void btn_Lis‰‰_Click(object sender, EventArgs e)
        {
            string key = textBox_Lis‰‰Key.Text.Trim();
            string value = textBox_Lis‰‰Value.Text.Trim();

            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                myDictionary[key] = value;
                MessageBox.Show("Key/Value pair added successfully!");
            }
        }

        private void button_Hae_Click(object sender, EventArgs e)
        {
            string key = textBox_HaeKey.Text.Trim();
            if (!string.IsNullOrEmpty(key))
            {
                if (myDictionary.ContainsKey(key))
                {
                    label_HaeValue.Text = myDictionary[key];
                }
                else
                {
                    MessageBox.Show("Key not found in the dictionary.");
                }
            }
        }
    }
}
