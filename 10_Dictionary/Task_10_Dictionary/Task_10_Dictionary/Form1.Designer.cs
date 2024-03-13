namespace Task_10_Dictionary
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
            label_LuodanDic = new Label();
            btn_LuoDic = new Button();
            label_LisätäänElementtejä = new Label();
            label_Key = new Label();
            label_Value = new Label();
            btn_Lisää = new Button();
            textBox_LisääKey = new TextBox();
            textBox_LisääValue = new TextBox();
            label_HaetaanElementtejä = new Label();
            label_Key2 = new Label();
            label_Value2 = new Label();
            textBox_HaeKey = new TextBox();
            button_Hae = new Button();
            label_HaeValue = new Label();
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
            menuStrip1.Size = new Size(823, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // label_LuodanDic
            // 
            label_LuodanDic.AutoSize = true;
            label_LuodanDic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_LuodanDic.Location = new Point(283, 50);
            label_LuodanDic.Name = "label_LuodanDic";
            label_LuodanDic.Size = new Size(191, 28);
            label_LuodanDic.TabIndex = 1;
            label_LuodanDic.Text = "LUODAN Dictionary";
            // 
            // btn_LuoDic
            // 
            btn_LuoDic.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LuoDic.Location = new Point(298, 90);
            btn_LuoDic.Name = "btn_LuoDic";
            btn_LuoDic.Size = new Size(157, 40);
            btn_LuoDic.TabIndex = 2;
            btn_LuoDic.Text = "Luo Dictionary";
            btn_LuoDic.UseVisualStyleBackColor = true;
            btn_LuoDic.Click += btn_LuoDic_Click;
            // 
            // label_LisätäänElementtejä
            // 
            label_LisätäänElementtejä.AutoSize = true;
            label_LisätäänElementtejä.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_LisätäänElementtejä.Location = new Point(261, 173);
            label_LisätäänElementtejä.Name = "label_LisätäänElementtejä";
            label_LisätäänElementtejä.Size = new Size(235, 28);
            label_LisätäänElementtejä.TabIndex = 3;
            label_LisätäänElementtejä.Text = "LISÄTÄÄN ELEMENTTEJÄ";
            // 
            // label_Key
            // 
            label_Key.AutoSize = true;
            label_Key.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Key.Location = new Point(158, 218);
            label_Key.Name = "label_Key";
            label_Key.Size = new Size(50, 28);
            label_Key.TabIndex = 4;
            label_Key.Text = "Key:";
            // 
            // label_Value
            // 
            label_Value.AutoSize = true;
            label_Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Value.Location = new Point(158, 259);
            label_Value.Name = "label_Value";
            label_Value.Size = new Size(67, 28);
            label_Value.TabIndex = 5;
            label_Value.Text = "Value:";
            // 
            // btn_Lisää
            // 
            btn_Lisää.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Lisää.Location = new Point(471, 263);
            btn_Lisää.Name = "btn_Lisää";
            btn_Lisää.Size = new Size(114, 29);
            btn_Lisää.TabIndex = 6;
            btn_Lisää.Text = "Lisää";
            btn_Lisää.UseVisualStyleBackColor = true;
            btn_Lisää.Click += btn_Lisää_Click;
            // 
            // textBox_LisääKey
            // 
            textBox_LisääKey.Location = new Point(283, 219);
            textBox_LisääKey.Name = "textBox_LisääKey";
            textBox_LisääKey.Size = new Size(146, 27);
            textBox_LisääKey.TabIndex = 7;
            // 
            // textBox_LisääValue
            // 
            textBox_LisääValue.Location = new Point(283, 263);
            textBox_LisääValue.Name = "textBox_LisääValue";
            textBox_LisääValue.Size = new Size(146, 27);
            textBox_LisääValue.TabIndex = 8;
            // 
            // label_HaetaanElementtejä
            // 
            label_HaetaanElementtejä.AutoSize = true;
            label_HaetaanElementtejä.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_HaetaanElementtejä.Location = new Point(262, 333);
            label_HaetaanElementtejä.Name = "label_HaetaanElementtejä";
            label_HaetaanElementtejä.Size = new Size(234, 28);
            label_HaetaanElementtejä.TabIndex = 9;
            label_HaetaanElementtejä.Text = "HAETAAN ELEMENTTEJÄ";
            // 
            // label_Key2
            // 
            label_Key2.AutoSize = true;
            label_Key2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Key2.Location = new Point(158, 374);
            label_Key2.Name = "label_Key2";
            label_Key2.Size = new Size(50, 28);
            label_Key2.TabIndex = 10;
            label_Key2.Text = "Key:";
            // 
            // label_Value2
            // 
            label_Value2.AutoSize = true;
            label_Value2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Value2.Location = new Point(158, 422);
            label_Value2.Name = "label_Value2";
            label_Value2.Size = new Size(67, 28);
            label_Value2.TabIndex = 11;
            label_Value2.Text = "Value:";
            // 
            // textBox_HaeKey
            // 
            textBox_HaeKey.Location = new Point(283, 378);
            textBox_HaeKey.Name = "textBox_HaeKey";
            textBox_HaeKey.Size = new Size(146, 27);
            textBox_HaeKey.TabIndex = 12;
            // 
            // button_Hae
            // 
            button_Hae.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Hae.Location = new Point(471, 376);
            button_Hae.Name = "button_Hae";
            button_Hae.Size = new Size(114, 29);
            button_Hae.TabIndex = 14;
            button_Hae.Text = "Hae";
            button_Hae.UseVisualStyleBackColor = true;
            button_Hae.Click += button_Hae_Click;
            // 
            // label_HaeValue
            // 
            label_HaeValue.AutoSize = true;
            label_HaeValue.BackColor = Color.FromArgb(192, 255, 255);
            label_HaeValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HaeValue.ForeColor = Color.Black;
            label_HaeValue.Location = new Point(283, 430);
            label_HaeValue.Name = "label_HaeValue";
            label_HaeValue.Size = new Size(0, 28);
            label_HaeValue.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(823, 527);
            Controls.Add(label_HaeValue);
            Controls.Add(button_Hae);
            Controls.Add(textBox_HaeKey);
            Controls.Add(label_Value2);
            Controls.Add(label_Key2);
            Controls.Add(label_HaetaanElementtejä);
            Controls.Add(textBox_LisääValue);
            Controls.Add(textBox_LisääKey);
            Controls.Add(btn_Lisää);
            Controls.Add(label_Value);
            Controls.Add(label_Key);
            Controls.Add(label_LisätäänElementtejä);
            Controls.Add(btn_LuoDic);
            Controls.Add(label_LuodanDic);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Pääformi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Label label_LuodanDic;
        private Button btn_LuoDic;
        private Label label_LisätäänElementtejä;
        private Label label_Key;
        private Label label_Value;
        private Button btn_Lisää;
        private TextBox textBox_LisääKey;
        private TextBox textBox_LisääValue;
        private Label label_HaetaanElementtejä;
        private Label label_Key2;
        private Label label_Value2;
        private TextBox textBox_HaeKey;
        private Button button_Hae;
        private Label label_HaeValue;
    }
}
