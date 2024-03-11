namespace Task_4_Switch
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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_default = new Button();
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
            menuStrip1.Size = new Size(572, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_1.Location = new Point(27, 52);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(129, 46);
            btn_1.TabIndex = 1;
            btn_1.Text = "Valinta 1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += this.btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_2.Location = new Point(27, 120);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(129, 47);
            btn_2.TabIndex = 2;
            btn_2.Text = "Valinta 2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += this.btn_1_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_3.Location = new Point(27, 188);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(129, 44);
            btn_3.TabIndex = 3;
            btn_3.Text = "Valinta 3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += this.btn_1_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_4.Location = new Point(27, 254);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(129, 44);
            btn_4.TabIndex = 4;
            btn_4.Text = "Valinta 4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += this.btn_1_Click;
            // 
            // btn_default
            // 
            btn_default.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_default.Location = new Point(27, 323);
            btn_default.Name = "btn_default";
            btn_default.Size = new Size(129, 43);
            btn_default.TabIndex = 5;
            btn_default.Text = "Default";
            btn_default.UseVisualStyleBackColor = true;
            btn_default.Click += this.btn_1_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(572, 450);
            Controls.Add(btn_default);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Form";
            Text = "Pääformi";
            Click += this.btn_1_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_default;
    }
}
