namespace Task_4_Switch
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;

            if (pressedButton != null)
            {
                switch (pressedButton.Name)
                {
                    case "btn_1":
                        MessageBox.Show("Valinta 1", "HUOM");
                        break;
                    case "btn_2":
                        MessageBox.Show("Valinta 2", "HUOM");
                        break;
                    case "btn_3":
                        MessageBox.Show("Valinta 3", "HUOM");
                        break;
                    case "btn_4":
                        MessageBox.Show("Valinta 4", "HUOM");
                        break;
                    case "btn_default":
                        MessageBox.Show("Default", "HUOM");
                        break;
                }
            }
        }
    }
}
