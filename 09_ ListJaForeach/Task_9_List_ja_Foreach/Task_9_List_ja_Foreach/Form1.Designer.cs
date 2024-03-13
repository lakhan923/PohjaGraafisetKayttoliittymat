namespace Task_9_List_ja_Foreach
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
            label_LuodanLista = new Label();
            btn_LuoLista = new Button();
            label_LisätäänListanMerkkijono = new Label();
            textBox_LisätäänListanMerkkijono = new TextBox();
            btn_Lisää = new Button();
            label_HaetaanListanSisältö = new Label();
            btn_Haku = new Button();
            comboBox_Haku = new ComboBox();
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
            // label_LuodanLista
            // 
            label_LuodanLista.AutoSize = true;
            label_LuodanLista.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_LuodanLista.Location = new Point(238, 45);
            label_LuodanLista.Name = "label_LuodanLista";
            label_LuodanLista.Size = new Size(292, 25);
            label_LuodanLista.TabIndex = 1;
            label_LuodanLista.Text = "LUODAN string-TYYPPINEN LISTA";
            // 
            // btn_LuoLista
            // 
            btn_LuoLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LuoLista.Location = new Point(330, 88);
            btn_LuoLista.Name = "btn_LuoLista";
            btn_LuoLista.Size = new Size(112, 29);
            btn_LuoLista.TabIndex = 2;
            btn_LuoLista.Text = "Luo Lista";
            btn_LuoLista.UseVisualStyleBackColor = true;
            btn_LuoLista.Click += btn_LuoLista_Click;
            // 
            // label_LisätäänListanMerkkijono
            // 
            label_LisätäänListanMerkkijono.AutoSize = true;
            label_LisätäänListanMerkkijono.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_LisätäänListanMerkkijono.Location = new Point(238, 173);
            label_LisätäänListanMerkkijono.Name = "label_LisätäänListanMerkkijono";
            label_LisätäänListanMerkkijono.Size = new Size(276, 25);
            label_LisätäänListanMerkkijono.TabIndex = 3;
            label_LisätäänListanMerkkijono.Text = "LISÄTÄÄN LISTAN MERKKIJONO";
            // 
            // textBox_LisätäänListanMerkkijono
            // 
            textBox_LisätäänListanMerkkijono.Location = new Point(167, 214);
            textBox_LisätäänListanMerkkijono.Name = "textBox_LisätäänListanMerkkijono";
            textBox_LisätäänListanMerkkijono.Size = new Size(250, 27);
            textBox_LisätäänListanMerkkijono.TabIndex = 4;
            // 
            // btn_Lisää
            // 
            btn_Lisää.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Lisää.Location = new Point(436, 212);
            btn_Lisää.Name = "btn_Lisää";
            btn_Lisää.Size = new Size(94, 29);
            btn_Lisää.TabIndex = 5;
            btn_Lisää.Text = "Lisää";
            btn_Lisää.UseVisualStyleBackColor = true;
            btn_Lisää.Click += btn_Lisää_Click;
            // 
            // label_HaetaanListanSisältö
            // 
            label_HaetaanListanSisältö.AutoSize = true;
            label_HaetaanListanSisältö.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HaetaanListanSisältö.Location = new Point(238, 292);
            label_HaetaanListanSisältö.Name = "label_HaetaanListanSisältö";
            label_HaetaanListanSisältö.Size = new Size(230, 25);
            label_HaetaanListanSisältö.TabIndex = 6;
            label_HaetaanListanSisältö.Text = "HAETAAN LISTAN SISÄLTÖ";
            // 
            // btn_Haku
            // 
            btn_Haku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Haku.Location = new Point(436, 346);
            btn_Haku.Name = "btn_Haku";
            btn_Haku.Size = new Size(94, 29);
            btn_Haku.TabIndex = 7;
            btn_Haku.Text = "Haku";
            btn_Haku.UseVisualStyleBackColor = true;
            btn_Haku.Click += btn_Haku_Click;
            // 
            // comboBox_Haku
            // 
            comboBox_Haku.FormattingEnabled = true;
            comboBox_Haku.Location = new Point(167, 347);
            comboBox_Haku.Name = "comboBox_Haku";
            comboBox_Haku.Size = new Size(250, 28);
            comboBox_Haku.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_Haku);
            Controls.Add(btn_Haku);
            Controls.Add(label_HaetaanListanSisältö);
            Controls.Add(btn_Lisää);
            Controls.Add(textBox_LisätäänListanMerkkijono);
            Controls.Add(label_LisätäänListanMerkkijono);
            Controls.Add(btn_LuoLista);
            Controls.Add(label_LuodanLista);
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
        private Label label_LuodanLista;
        private Button btn_LuoLista;
        private Label label_LisätäänListanMerkkijono;
        private TextBox textBox_LisätäänListanMerkkijono;
        private Button btn_Lisää;
        private Label label_HaetaanListanSisältö;
        private Button btn_Haku;
        private ComboBox comboBox_Haku;
    }
}
