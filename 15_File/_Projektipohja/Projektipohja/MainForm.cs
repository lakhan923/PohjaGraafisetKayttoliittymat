using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projektipohja
{
    public partial class MainForm : Form
    {
        private string EditorFileName = "Untitled";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Helper method to set the form title text
        private void SetFormTitleText()
        {
            // Get the file name for display in the form title bar
            FileInfo fileInfo = new FileInfo(EditorFileName);
            Text = fileInfo.Name + " - Editor";
        }

        private void MenuFileNew_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";
            richTextBox1.Clear();
            SetFormTitleText();
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open";
                openFileDialog.ShowReadOnly = true;
                openFileDialog.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    EditorFileName = openFileDialog.FileName;
                    ReadFile();
                    SetFormTitleText();
                }
            }
        }

        private void ReadFile()
        {
            try
            {
                // Luodaan StreamReader objekti ja luetaan tiedosto. 
                using (StreamReader Reader = new StreamReader(EditorFileName))
                {
                    // Luku 
                    richTextBox1.Clear();
                    richTextBox1.Text = Reader.ReadToEnd();
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File",
                                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            if (EditorFileName == "Untitled")
            {
                MenuFileSave_Click(sender, e);
            }
            else
            {
                SaveFile();
            }
        }

        private void SaveFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(EditorFileName))
                {
                    writer.Write(richTextBox1.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MenuFileSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    EditorFileName = saveFileDialog.FileName;
                    SaveFile();
                    SetFormTitleText();
                }
            }
        }
    }
}
