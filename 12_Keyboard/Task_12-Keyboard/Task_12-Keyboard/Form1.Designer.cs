namespace Task_12_Keyboard
{
    partial class Form1
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
            button_EnterDesireXY = new Button();
            textBox_Coordinates = new TextBox();
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
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // button_EnterDesireXY
            // 
            button_EnterDesireXY.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_EnterDesireXY.Location = new Point(560, 74);
            button_EnterDesireXY.Name = "button_EnterDesireXY";
            button_EnterDesireXY.Size = new Size(94, 29);
            button_EnterDesireXY.TabIndex = 1;
            button_EnterDesireXY.Text = "Draw";
            button_EnterDesireXY.UseVisualStyleBackColor = true;
            button_EnterDesireXY.Click += button_EnterDesireXY_Click;
            // 
            // textBox_Coordinates
            // 
            textBox_Coordinates.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Coordinates.Location = new Point(349, 75);
            textBox_Coordinates.Name = "textBox_Coordinates";
            textBox_Coordinates.Size = new Size(194, 27);
            textBox_Coordinates.TabIndex = 2;
            textBox_Coordinates.TabStop = false;
            textBox_Coordinates.Text = "Enter coordinates for x,y";
            textBox_Coordinates.Enter += textBox_Coordinates_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_Coordinates);
            Controls.Add(button_EnterDesireXY);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Pääformi";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            MouseDown += Form1_MouseDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Button button_EnterDesireXY;
        private TextBox textBox_Coordinates;
    }
}
