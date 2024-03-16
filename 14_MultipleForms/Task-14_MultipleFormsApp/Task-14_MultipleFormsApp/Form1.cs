namespace Task_14_MultipleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OpenSecondaryForm_Click(object sender, EventArgs e)
        {
            SecondaryForm secondaryForm = new SecondaryForm();
            secondaryForm.DataFromMainForm = "Hello from the Main Form!";
            secondaryForm.Show();
            secondaryForm.UpdateUIWithData();
        }
    }
}
