
namespace Task_5_For
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            textBox_Integers = new TextBox();
            StartButton = new Button();
            labelNumbers = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(581, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // textBox_Integers
            // 
            textBox_Integers.Location = new Point(72, 68);
            textBox_Integers.Name = "textBox_Integers";
            textBox_Integers.Size = new Size(144, 27);
            textBox_Integers.TabIndex = 1;
            textBox_Integers.Text = "1230";
            // 
            // StartButton
            // 
            StartButton.Location = new Point(254, 68);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(136, 29);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // labelNumbers
            // 
            labelNumbers.AutoSize = true;
            labelNumbers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumbers.Location = new Point(106, 146);
            labelNumbers.Name = "labelNumbers";
            labelNumbers.Size = new Size(45, 20);
            labelNumbers.TabIndex = 3;
            labelNumbers.Text = "1149";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 156);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(label1);
            Controls.Add(labelNumbers);
            Controls.Add(StartButton);
            Controls.Add(textBox_Integers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form";
            Text = "Pääformi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TextBox textBox_Integers;
        private Button StartButton;
        private Label labelNumbers;
        private Label label1;
    }
}
