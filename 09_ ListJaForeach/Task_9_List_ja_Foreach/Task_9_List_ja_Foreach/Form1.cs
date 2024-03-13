namespace Task_9_List_ja_Foreach
{
    public partial class Form1 : Form
    {
        // list of string
        private List<string> stringList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LuoLista_Click(object sender, EventArgs e)
        {
            // clear existing items in the list
            stringList.Clear();

            // add strings to the list
            stringList.Add("Akku");
            stringList.Add("Hessu");
            stringList.Add("Roope");
            stringList.Add("Mikki");
        }

        private void btn_Lis‰‰_Click(object sender, EventArgs e)
        {
            // Get a new string from the text field
            string uusiMerkkijono = textBox_Lis‰t‰‰nListanMerkkijono.Text.Trim(); 
            if (!string.IsNullOrEmpty(uusiMerkkijono))
            {
                // Add a new string to the list
                stringList.Add(uusiMerkkijono);
            }
        }

        private void btn_Haku_Click(object sender, EventArgs e)
        {
            // Empty the ComboBox
            comboBox_Haku.Items.Clear();

            // Add each string in the list to the ComboBox component
            foreach (string merkkijono in stringList)
            {
                comboBox_Haku.Items.Add(merkkijono);
            }
        }
    }
}
