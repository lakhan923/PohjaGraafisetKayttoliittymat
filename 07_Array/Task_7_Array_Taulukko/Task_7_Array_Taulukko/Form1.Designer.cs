namespace Task_7_Array_Taulukko
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
            label_TaulukonLuonti = new Label();
            label_TaulukonKoko = new Label();
            button_LuoTaulukko = new Button();
            textBox_TaulukonKoko = new TextBox();
            label_Tallennus = new Label();
            label_TalletettavaNumero = new Label();
            textBox_TalletettavaNumero = new TextBox();
            label_TalletuspaikanIndeksi = new Label();
            textBox_TallestuspaikanIndeksi = new TextBox();
            button_Talleta = new Button();
            label_Haku = new Label();
            label_HakuTalletuspaikanIndeksi = new Label();
            textBox_HakuTalletuspaikanIndeksi = new TextBox();
            button_Hae = new Button();
            textBox_HakuTulos = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(579, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // label_TaulukonLuonti
            // 
            label_TaulukonLuonti.AutoSize = true;
            label_TaulukonLuonti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_TaulukonLuonti.Location = new Point(304, 44);
            label_TaulukonLuonti.Name = "label_TaulukonLuonti";
            label_TaulukonLuonti.Size = new Size(143, 20);
            label_TaulukonLuonti.TabIndex = 1;
            label_TaulukonLuonti.Text = "TAULUKON LUONTI";
            // 
            // label_TaulukonKoko
            // 
            label_TaulukonKoko.AutoSize = true;
            label_TaulukonKoko.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TaulukonKoko.Location = new Point(64, 99);
            label_TaulukonKoko.Name = "label_TaulukonKoko";
            label_TaulukonKoko.Size = new Size(118, 20);
            label_TaulukonKoko.TabIndex = 2;
            label_TaulukonKoko.Text = "Taulukon koko :";
            // 
            // button_LuoTaulukko
            // 
            button_LuoTaulukko.BackColor = Color.FromArgb(128, 255, 255);
            button_LuoTaulukko.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_LuoTaulukko.Location = new Point(366, 92);
            button_LuoTaulukko.Name = "button_LuoTaulukko";
            button_LuoTaulukko.Size = new Size(140, 31);
            button_LuoTaulukko.TabIndex = 3;
            button_LuoTaulukko.Text = "Luo Taulukko";
            button_LuoTaulukko.UseVisualStyleBackColor = false;
            button_LuoTaulukko.Click += button_LuoTaulukko_Click;
            // 
            // textBox_TaulukonKoko
            // 
            textBox_TaulukonKoko.Location = new Point(235, 96);
            textBox_TaulukonKoko.Name = "textBox_TaulukonKoko";
            textBox_TaulukonKoko.Size = new Size(77, 27);
            textBox_TaulukonKoko.TabIndex = 4;
            textBox_TaulukonKoko.Text = "10";
            // 
            // label_Tallennus
            // 
            label_Tallennus.AutoSize = true;
            label_Tallennus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_Tallennus.Location = new Point(304, 151);
            label_Tallennus.Name = "label_Tallennus";
            label_Tallennus.Size = new Size(91, 20);
            label_Tallennus.TabIndex = 5;
            label_Tallennus.Text = "TALLENNUS";
            // 
            // label_TalletettavaNumero
            // 
            label_TalletettavaNumero.AutoSize = true;
            label_TalletettavaNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TalletettavaNumero.Location = new Point(64, 189);
            label_TalletettavaNumero.Name = "label_TalletettavaNumero";
            label_TalletettavaNumero.Size = new Size(153, 20);
            label_TalletettavaNumero.TabIndex = 6;
            label_TalletettavaNumero.Text = "Talletettava numero :";
            // 
            // textBox_TalletettavaNumero
            // 
            textBox_TalletettavaNumero.Location = new Point(240, 189);
            textBox_TalletettavaNumero.Name = "textBox_TalletettavaNumero";
            textBox_TalletettavaNumero.Size = new Size(72, 27);
            textBox_TalletettavaNumero.TabIndex = 7;
            textBox_TalletettavaNumero.Text = "313";
            // 
            // label_TalletuspaikanIndeksi
            // 
            label_TalletuspaikanIndeksi.AutoSize = true;
            label_TalletuspaikanIndeksi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TalletuspaikanIndeksi.Location = new Point(64, 238);
            label_TalletuspaikanIndeksi.Name = "label_TalletuspaikanIndeksi";
            label_TalletuspaikanIndeksi.Size = new Size(166, 20);
            label_TalletuspaikanIndeksi.TabIndex = 8;
            label_TalletuspaikanIndeksi.Text = "Talletuspaikan indeksi :";
            // 
            // textBox_TallestuspaikanIndeksi
            // 
            textBox_TallestuspaikanIndeksi.Location = new Point(240, 238);
            textBox_TallestuspaikanIndeksi.Name = "textBox_TallestuspaikanIndeksi";
            textBox_TallestuspaikanIndeksi.Size = new Size(74, 27);
            textBox_TallestuspaikanIndeksi.TabIndex = 9;
            textBox_TallestuspaikanIndeksi.Text = "4";
            // 
            // button_Talleta
            // 
            button_Talleta.BackColor = Color.Lime;
            button_Talleta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Talleta.Location = new Point(366, 235);
            button_Talleta.Name = "button_Talleta";
            button_Talleta.Size = new Size(140, 33);
            button_Talleta.TabIndex = 10;
            button_Talleta.Text = "Talleta";
            button_Talleta.UseVisualStyleBackColor = false;
            button_Talleta.Click += button_Talleta_Click;
            // 
            // label_Haku
            // 
            label_Haku.AutoSize = true;
            label_Haku.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_Haku.Location = new Point(317, 294);
            label_Haku.Name = "label_Haku";
            label_Haku.Size = new Size(45, 20);
            label_Haku.TabIndex = 11;
            label_Haku.Text = "Haku";
            // 
            // label_HakuTalletuspaikanIndeksi
            // 
            label_HakuTalletuspaikanIndeksi.AutoSize = true;
            label_HakuTalletuspaikanIndeksi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HakuTalletuspaikanIndeksi.Location = new Point(69, 338);
            label_HakuTalletuspaikanIndeksi.Name = "label_HakuTalletuspaikanIndeksi";
            label_HakuTalletuspaikanIndeksi.Size = new Size(166, 20);
            label_HakuTalletuspaikanIndeksi.TabIndex = 12;
            label_HakuTalletuspaikanIndeksi.Text = "Talletuspaikan indeksi :";
            // 
            // textBox_HakuTalletuspaikanIndeksi
            // 
            textBox_HakuTalletuspaikanIndeksi.Location = new Point(245, 337);
            textBox_HakuTalletuspaikanIndeksi.Name = "textBox_HakuTalletuspaikanIndeksi";
            textBox_HakuTalletuspaikanIndeksi.Size = new Size(69, 27);
            textBox_HakuTalletuspaikanIndeksi.TabIndex = 13;
            textBox_HakuTalletuspaikanIndeksi.Text = "4";
            // 
            // button_Hae
            // 
            button_Hae.BackColor = Color.Silver;
            button_Hae.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Hae.Location = new Point(366, 338);
            button_Hae.Name = "button_Hae";
            button_Hae.Size = new Size(140, 29);
            button_Hae.TabIndex = 14;
            button_Hae.Text = "Hae";
            button_Hae.UseVisualStyleBackColor = false;
            button_Hae.Click += button_Hae_Click;
            // 
            // textBox_HakuTulos
            // 
            textBox_HakuTulos.BackColor = Color.FromArgb(192, 255, 255);
            textBox_HakuTulos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_HakuTulos.Location = new Point(317, 384);
            textBox_HakuTulos.Name = "textBox_HakuTulos";
            textBox_HakuTulos.Size = new Size(53, 30);
            textBox_HakuTulos.TabIndex = 15;
            textBox_HakuTulos.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(textBox_HakuTulos);
            Controls.Add(button_Hae);
            Controls.Add(textBox_HakuTalletuspaikanIndeksi);
            Controls.Add(label_HakuTalletuspaikanIndeksi);
            Controls.Add(label_Haku);
            Controls.Add(button_Talleta);
            Controls.Add(textBox_TallestuspaikanIndeksi);
            Controls.Add(label_TalletuspaikanIndeksi);
            Controls.Add(textBox_TalletettavaNumero);
            Controls.Add(label_TalletettavaNumero);
            Controls.Add(label_Tallennus);
            Controls.Add(textBox_TaulukonKoko);
            Controls.Add(button_LuoTaulukko);
            Controls.Add(label_TaulukonKoko);
            Controls.Add(label_TaulukonLuonti);
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
        private Label label_TaulukonLuonti;
        private Label label_TaulukonKoko;
        private Button button_LuoTaulukko;
        private TextBox textBox_TaulukonKoko;
        private Label label_Tallennus;
        private Label label_TalletettavaNumero;
        private TextBox textBox_TalletettavaNumero;
        private Label label_TalletuspaikanIndeksi;
        private TextBox textBox_TallestuspaikanIndeksi;
        private Button button_Talleta;
        private Label label_Haku;
        private Label label_HakuTalletuspaikanIndeksi;
        private TextBox textBox_HakuTalletuspaikanIndeksi;
        private Button button_Hae;
        private TextBox textBox_HakuTulos;
    }
}
