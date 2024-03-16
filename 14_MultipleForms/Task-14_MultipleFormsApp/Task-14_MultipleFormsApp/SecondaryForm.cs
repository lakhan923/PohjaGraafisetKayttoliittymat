using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_14_MultipleFormsApp
{
    public partial class SecondaryForm : Form
    {
        public string DataFromMainForm { get; set; }

        public SecondaryForm()
        {
            InitializeComponent();
        }

        // Method to update UI with the received data
        public void UpdateUIWithData()
        {
            // Display received data in a label
            label_RecievedData.Text = DataFromMainForm;
        }
    }
}
