namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1_ElokuvanTiedot = new System.Windows.Forms.GroupBox();
            this.groupBox2_Toiminnallisuus = new System.Windows.Forms.GroupBox();
            this.groupBox3_Arvio = new System.Windows.Forms.GroupBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Nimi = new System.Windows.Forms.Label();
            this.label_Julkaisuvuosi = new System.Windows.Forms.Label();
            this.label_Kesto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Edellinen = new System.Windows.Forms.Button();
            this.btn_Seuraava = new System.Windows.Forms.Button();
            this.btn_UusiTietue = new System.Windows.Forms.Button();
            this.btn_Tallenna = new System.Windows.Forms.Button();
            this.btn_Poista = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_Arvio = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label_dot = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1_ElokuvanTiedot.SuspendLayout();
            this.groupBox2_Toiminnallisuus.SuspendLayout();
            this.groupBox3_Arvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // groupBox1_ElokuvanTiedot
            // 
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.btn_Seuraava);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.btn_Edellinen);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.textBox4);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.textBox3);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.textBox2);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.textBox1);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.label_Kesto);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.label_Julkaisuvuosi);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.label_Nimi);
            this.groupBox1_ElokuvanTiedot.Controls.Add(this.label_ID);
            this.groupBox1_ElokuvanTiedot.Location = new System.Drawing.Point(12, 39);
            this.groupBox1_ElokuvanTiedot.Name = "groupBox1_ElokuvanTiedot";
            this.groupBox1_ElokuvanTiedot.Size = new System.Drawing.Size(439, 249);
            this.groupBox1_ElokuvanTiedot.TabIndex = 1;
            this.groupBox1_ElokuvanTiedot.TabStop = false;
            this.groupBox1_ElokuvanTiedot.Text = "Elokuvan tiedot";
            // 
            // groupBox2_Toiminnallisuus
            // 
            this.groupBox2_Toiminnallisuus.Controls.Add(this.btn_Poista);
            this.groupBox2_Toiminnallisuus.Controls.Add(this.btn_Tallenna);
            this.groupBox2_Toiminnallisuus.Controls.Add(this.btn_UusiTietue);
            this.groupBox2_Toiminnallisuus.Location = new System.Drawing.Point(522, 39);
            this.groupBox2_Toiminnallisuus.Name = "groupBox2_Toiminnallisuus";
            this.groupBox2_Toiminnallisuus.Size = new System.Drawing.Size(266, 423);
            this.groupBox2_Toiminnallisuus.TabIndex = 2;
            this.groupBox2_Toiminnallisuus.TabStop = false;
            this.groupBox2_Toiminnallisuus.Text = "Toiminnallisuus";
            // 
            // groupBox3_Arvio
            // 
            this.groupBox3_Arvio.Controls.Add(this.label_dot);
            this.groupBox3_Arvio.Controls.Add(this.numericUpDown2);
            this.groupBox3_Arvio.Controls.Add(this.numericUpDown1);
            this.groupBox3_Arvio.Controls.Add(this.label_Arvio);
            this.groupBox3_Arvio.Controls.Add(this.richTextBox1);
            this.groupBox3_Arvio.Location = new System.Drawing.Point(12, 294);
            this.groupBox3_Arvio.Name = "groupBox3_Arvio";
            this.groupBox3_Arvio.Size = new System.Drawing.Size(448, 168);
            this.groupBox3_Arvio.TabIndex = 3;
            this.groupBox3_Arvio.TabStop = false;
            this.groupBox3_Arvio.Text = "Arvio";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(32, 41);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID:";
            // 
            // label_Nimi
            // 
            this.label_Nimi.AutoSize = true;
            this.label_Nimi.Location = new System.Drawing.Point(32, 83);
            this.label_Nimi.Name = "label_Nimi";
            this.label_Nimi.Size = new System.Drawing.Size(30, 13);
            this.label_Nimi.TabIndex = 1;
            this.label_Nimi.Text = "Nimi:";
            // 
            // label_Julkaisuvuosi
            // 
            this.label_Julkaisuvuosi.AutoSize = true;
            this.label_Julkaisuvuosi.Location = new System.Drawing.Point(32, 126);
            this.label_Julkaisuvuosi.Name = "label_Julkaisuvuosi";
            this.label_Julkaisuvuosi.Size = new System.Drawing.Size(73, 13);
            this.label_Julkaisuvuosi.TabIndex = 2;
            this.label_Julkaisuvuosi.Text = "Julkaisuvuosi:";
            // 
            // label_Kesto
            // 
            this.label_Kesto.AutoSize = true;
            this.label_Kesto.Location = new System.Drawing.Point(32, 164);
            this.label_Kesto.Name = "label_Kesto";
            this.label_Kesto.Size = new System.Drawing.Size(62, 13);
            this.label_Kesto.TabIndex = 3;
            this.label_Kesto.Text = "Kesto (min):";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(176, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(176, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(176, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(176, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btn_Edellinen
            // 
            this.btn_Edellinen.Location = new System.Drawing.Point(35, 197);
            this.btn_Edellinen.Name = "btn_Edellinen";
            this.btn_Edellinen.Size = new System.Drawing.Size(125, 46);
            this.btn_Edellinen.TabIndex = 8;
            this.btn_Edellinen.Text = "Edellinen";
            this.btn_Edellinen.UseVisualStyleBackColor = true;
            // 
            // btn_Seuraava
            // 
            this.btn_Seuraava.Location = new System.Drawing.Point(199, 197);
            this.btn_Seuraava.Name = "btn_Seuraava";
            this.btn_Seuraava.Size = new System.Drawing.Size(133, 46);
            this.btn_Seuraava.TabIndex = 9;
            this.btn_Seuraava.Text = "Seuraava";
            this.btn_Seuraava.UseVisualStyleBackColor = true;
            // 
            // btn_UusiTietue
            // 
            this.btn_UusiTietue.Location = new System.Drawing.Point(57, 41);
            this.btn_UusiTietue.Name = "btn_UusiTietue";
            this.btn_UusiTietue.Size = new System.Drawing.Size(186, 66);
            this.btn_UusiTietue.TabIndex = 0;
            this.btn_UusiTietue.Text = "Uusi teitue";
            this.btn_UusiTietue.UseVisualStyleBackColor = true;
            // 
            // btn_Tallenna
            // 
            this.btn_Tallenna.BackColor = System.Drawing.Color.Lime;
            this.btn_Tallenna.Location = new System.Drawing.Point(57, 143);
            this.btn_Tallenna.Name = "btn_Tallenna";
            this.btn_Tallenna.Size = new System.Drawing.Size(186, 72);
            this.btn_Tallenna.TabIndex = 1;
            this.btn_Tallenna.Text = "Tallenna";
            this.btn_Tallenna.UseVisualStyleBackColor = false;
            // 
            // btn_Poista
            // 
            this.btn_Poista.BackColor = System.Drawing.Color.Red;
            this.btn_Poista.Location = new System.Drawing.Point(57, 246);
            this.btn_Poista.Name = "btn_Poista";
            this.btn_Poista.Size = new System.Drawing.Size(186, 67);
            this.btn_Poista.TabIndex = 2;
            this.btn_Poista.Text = "Poista";
            this.btn_Poista.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 92);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label_Arvio
            // 
            this.label_Arvio.AutoSize = true;
            this.label_Arvio.Location = new System.Drawing.Point(23, 131);
            this.label_Arvio.Name = "label_Arvio";
            this.label_Arvio.Size = new System.Drawing.Size(34, 13);
            this.label_Arvio.TabIndex = 1;
            this.label_Arvio.Text = "Arvio:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(64, 124);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(176, 124);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label_dot
            // 
            this.label_dot.AutoSize = true;
            this.label_dot.Location = new System.Drawing.Point(150, 126);
            this.label_dot.Name = "label_dot";
            this.label_dot.Size = new System.Drawing.Size(10, 13);
            this.label_dot.TabIndex = 4;
            this.label_dot.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 494);
            this.Controls.Add(this.groupBox3_Arvio);
            this.Controls.Add(this.groupBox2_Toiminnallisuus);
            this.Controls.Add(this.groupBox1_ElokuvanTiedot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elokuvansovellus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1_ElokuvanTiedot.ResumeLayout(false);
            this.groupBox1_ElokuvanTiedot.PerformLayout();
            this.groupBox2_Toiminnallisuus.ResumeLayout(false);
            this.groupBox3_Arvio.ResumeLayout(false);
            this.groupBox3_Arvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1_ElokuvanTiedot;
        private System.Windows.Forms.GroupBox groupBox2_Toiminnallisuus;
        private System.Windows.Forms.GroupBox groupBox3_Arvio;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Kesto;
        private System.Windows.Forms.Label label_Julkaisuvuosi;
        private System.Windows.Forms.Label label_Nimi;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button btn_Seuraava;
        private System.Windows.Forms.Button btn_Edellinen;
        private System.Windows.Forms.Button btn_Poista;
        private System.Windows.Forms.Button btn_Tallenna;
        private System.Windows.Forms.Button btn_UusiTietue;
        private System.Windows.Forms.Label label_dot;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_Arvio;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

