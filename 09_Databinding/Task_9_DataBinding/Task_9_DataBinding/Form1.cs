using System.ComponentModel;
using System;

namespace Task_9_DataBinding
{
    public partial class Form1 : Form
    {
        private BindingList<Person> listOfPersons;
        public Form1()
        {
            InitializeComponent();

            listOfPersons = new BindingList<Person>();
            DefaultPeopleData();
        }

        private void DefaultPeopleData()
        {
            // Populate the list with some initial data
            listOfPersons.Add(new Person("John", "Doe"));
            listOfPersons.Add(new Person("Jane", "Smith"));

            // Set up the data source
            comboBox_Henkilöt.DataSource = listOfPersons;
            comboBox_Henkilöt.DisplayMember = "LastName";

        }

        private void btn_Lisää_Click(object sender, EventArgs e)
        {
            // Add a new person to the list when the button is clicked
            string firstName = textBox_EtuNimi.Text;
            string lastName = textBox_SukuNimi.Text;
            listOfPersons.Add(new Person(firstName, lastName));
        }
    }
}
