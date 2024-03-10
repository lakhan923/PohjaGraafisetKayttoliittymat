using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task_2
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
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            groupBox1_ElokuvanTiedot = new GroupBox();
            btn_Seuraava = new Button();
            btn_Edellinen = new Button();
            textBox_Kesto = new TextBox();
            textBox_Julkaisuvuosi = new TextBox();
            textBox_Nimi = new TextBox();
            textBox_ID = new TextBox();
            label_Kesto = new Label();
            label_Julkaisuvuosi = new Label();
            label_Nimi = new Label();
            label_ID = new Label();
            groupBox2_Toiminnallisuus = new GroupBox();
            btn_Poista = new Button();
            btn_Poista = new Button();
            btn_Tallenna = new Button();
            btn_UusiTietue = new Button();
            groupBox3_Arvio = new GroupBox();
            label_dot = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label_Arvio = new Label();
            richTextBox_Arvio = new RichTextBox();
            menuStrip1.SuspendLayout();
            groupBox1_ElokuvanTiedot.SuspendLayout();
            groupBox2_Toiminnallisuus.SuspendLayout();
            groupBox3_Arvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, tietojaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(971, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(64, 20);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.Size = new Size(107, 22);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // tietojaToolStripMenuItem
            // 
            tietojaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem });
            tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            tietojaToolStripMenuItem.Size = new Size(54, 20);
            tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(95, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // groupBox1_ElokuvanTiedot
            // 
            groupBox1_ElokuvanTiedot.Controls.Add(btn_Seuraava);
            groupBox1_ElokuvanTiedot.Controls.Add(btn_Edellinen);
            groupBox1_ElokuvanTiedot.Controls.Add(textBox_Kesto);
            groupBox1_ElokuvanTiedot.Controls.Add(textBox_Julkaisuvuosi);
            groupBox1_ElokuvanTiedot.Controls.Add(textBox_Nimi);
            groupBox1_ElokuvanTiedot.Controls.Add(textBox_ID);
            groupBox1_ElokuvanTiedot.Controls.Add(label_Kesto);
            groupBox1_ElokuvanTiedot.Controls.Add(label_Julkaisuvuosi);
            groupBox1_ElokuvanTiedot.Controls.Add(label_Nimi);
            groupBox1_ElokuvanTiedot.Controls.Add(label_ID);
            groupBox1_ElokuvanTiedot.Location = new Point(14, 45);
            groupBox1_ElokuvanTiedot.Margin = new Padding(4, 3, 4, 3);
            groupBox1_ElokuvanTiedot.Name = "groupBox1_ElokuvanTiedot";
            groupBox1_ElokuvanTiedot.Padding = new Padding(4, 3, 4, 3);
            groupBox1_ElokuvanTiedot.Size = new Size(512, 287);
            groupBox1_ElokuvanTiedot.TabIndex = 1;
            groupBox1_ElokuvanTiedot.TabStop = false;
            groupBox1_ElokuvanTiedot.Text = "Elokuvan tiedot";
            // 
            // btn_Seuraava
            // 
            btn_Seuraava.Location = new Point(232, 227);
            btn_Seuraava.Margin = new Padding(4, 3, 4, 3);
            btn_Seuraava.Name = "btn_Seuraava";
            btn_Seuraava.Size = new Size(155, 53);
            btn_Seuraava.TabIndex = 9;
            btn_Seuraava.Text = "Seuraava";
            btn_Seuraava.UseVisualStyleBackColor = true;
            // 
            // btn_Edellinen
            // 
            btn_Edellinen.Location = new Point(41, 227);
            btn_Edellinen.Margin = new Padding(4, 3, 4, 3);
            btn_Edellinen.Name = "btn_Edellinen";
            btn_Edellinen.Size = new Size(146, 53);
            btn_Edellinen.TabIndex = 8;
            btn_Edellinen.Text = "Edellinen";
            btn_Edellinen.UseVisualStyleBackColor = true;
            // 
            // textBox_Kesto
            // 
            textBox_Kesto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Kesto.Location = new Point(205, 186);
            textBox_Kesto.Margin = new Padding(4, 3, 4, 3);
            textBox_Kesto.Name = "textBox_Kesto";
            textBox_Kesto.Size = new Size(181, 23);
            textBox_Kesto.TabIndex = 7;
            textBox_Kesto.Enter += textBox_Kesto_Enter;
            textBox_Kesto.Leave += textBox_Kesto_Leave;
            // 
            // textBox_Julkaisuvuosi
            // 
            textBox_Julkaisuvuosi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Julkaisuvuosi.Location = new Point(205, 137);
            textBox_Julkaisuvuosi.Margin = new Padding(4, 3, 4, 3);
            textBox_Julkaisuvuosi.Name = "textBox_Julkaisuvuosi";
            textBox_Julkaisuvuosi.Size = new Size(181, 23);
            textBox_Julkaisuvuosi.TabIndex = 6;
            // 
            // textBox_Nimi
            // 
            textBox_Nimi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Nimi.Location = new Point(205, 88);
            textBox_Nimi.Margin = new Padding(4, 3, 4, 3);
            textBox_Nimi.Name = "textBox_Nimi";
            textBox_Nimi.Size = new Size(257, 23);
            textBox_Nimi.TabIndex = 5;
            textBox_Nimi.Enter += textBox_Nimi_Enter;
            textBox_Nimi.Leave += textBox_Nimi_Leave;
            // 
            // textBox_ID
            // 
            textBox_ID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_ID.Location = new Point(205, 39);
            textBox_ID.Margin = new Padding(4, 3, 4, 3);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(181, 23);
            textBox_ID.TabIndex = 4;
            // 
            // label_Kesto
            // 
            label_Kesto.AutoSize = true;
            label_Kesto.Location = new Point(37, 189);
            label_Kesto.Margin = new Padding(4, 0, 4, 0);
            label_Kesto.Name = "label_Kesto";
            label_Kesto.Size = new Size(71, 15);
            label_Kesto.TabIndex = 3;
            label_Kesto.Text = "Kesto (min):";
            // 
            // label_Julkaisuvuosi
            // 
            label_Julkaisuvuosi.AutoSize = true;
            label_Julkaisuvuosi.Location = new Point(37, 145);
            label_Julkaisuvuosi.Margin = new Padding(4, 0, 4, 0);
            label_Julkaisuvuosi.Name = "label_Julkaisuvuosi";
            label_Julkaisuvuosi.Size = new Size(79, 15);
            label_Julkaisuvuosi.TabIndex = 2;
            label_Julkaisuvuosi.Text = "Julkaisuvuosi:";
            // 
            // label_Nimi
            // 
            label_Nimi.AutoSize = true;
            label_Nimi.Location = new Point(37, 96);
            label_Nimi.Margin = new Padding(4, 0, 4, 0);
            label_Nimi.Name = "label_Nimi";
            label_Nimi.Size = new Size(36, 15);
            label_Nimi.TabIndex = 1;
            label_Nimi.Text = "Nimi:";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(37, 47);
            label_ID.Margin = new Padding(4, 0, 4, 0);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(21, 15);
            label_ID.TabIndex = 0;
            label_ID.Text = "ID:";
            // 
            // groupBox2_Toiminnallisuus
            // 
            groupBox2_Toiminnallisuus.Controls.Add(btn_Poista);
            groupBox2_Toiminnallisuus.Controls.Add(btn_Tallenna);
            groupBox2_Toiminnallisuus.Controls.Add(btn_UusiTietue);
            groupBox2_Toiminnallisuus.Location = new Point(572, 45);
            groupBox2_Toiminnallisuus.Margin = new Padding(4, 3, 4, 3);
            groupBox2_Toiminnallisuus.Name = "groupBox2_Toiminnallisuus";
            groupBox2_Toiminnallisuus.Padding = new Padding(4, 3, 4, 3);
            groupBox2_Toiminnallisuus.Size = new Size(348, 488);
            groupBox2_Toiminnallisuus.TabIndex = 2;
            groupBox2_Toiminnallisuus.TabStop = false;
            groupBox2_Toiminnallisuus.Text = "Toiminnallisuus";
            // 
            // btn_Poista
            // 
            btn_Poista.BackColor = Color.Red;
            btn_Poista.Location = new Point(66, 284);
            btn_Poista.Margin = new Padding(4, 3, 4, 3);
            btn_Poista.Name = "btn_Poista";
            btn_Poista.Size = new Size(217, 77);
            btn_Poista.TabIndex = 2;
            btn_Poista.Text = "Poista";
            btn_Poista.UseVisualStyleBackColor = false;
            // 
            // btn_Tallenna
            // 
            btn_Tallenna.BackColor = Color.Lime;
            btn_Tallenna.Location = new Point(66, 165);
            btn_Tallenna.Margin = new Padding(4, 3, 4, 3);
            btn_Tallenna.Name = "btn_Tallenna";
            btn_Tallenna.Size = new Size(217, 83);
            btn_Tallenna.TabIndex = 1;
            btn_Tallenna.Text = "Tallenna";
            btn_Tallenna.UseVisualStyleBackColor = false;
            // 
            // btn_UusiTietue
            // 
            btn_UusiTietue.Location = new Point(66, 47);
            btn_UusiTietue.Margin = new Padding(4, 3, 4, 3);
            btn_UusiTietue.Name = "btn_UusiTietue";
            btn_UusiTietue.Size = new Size(217, 76);
            btn_UusiTietue.TabIndex = 0;
            btn_UusiTietue.Text = "Uusi teitue";
            btn_UusiTietue.Click += btn_UusiTietue_Click;
            // 
            // groupBox3_Arvio
            // 
            groupBox3_Arvio.Controls.Add(label_dot);
            groupBox3_Arvio.Controls.Add(numericUpDown2);
            groupBox3_Arvio.Controls.Add(numericUpDown1);
            groupBox3_Arvio.Controls.Add(label_Arvio);
            groupBox3_Arvio.Controls.Add(richTextBox_Arvio);
            groupBox3_Arvio.Location = new Point(14, 339);
            groupBox3_Arvio.Margin = new Padding(4, 3, 4, 3);
            groupBox3_Arvio.Name = "groupBox3_Arvio";
            groupBox3_Arvio.Padding = new Padding(4, 3, 4, 3);
            groupBox3_Arvio.Size = new Size(512, 194);
            groupBox3_Arvio.TabIndex = 3;
            groupBox3_Arvio.TabStop = false;
            groupBox3_Arvio.Text = "Arvio";
            // 
            // label_dot
            // 
            label_dot.AutoSize = true;
            label_dot.Location = new Point(202, 151);
            label_dot.Margin = new Padding(4, 0, 4, 0);
            label_dot.Name = "label_dot";
            label_dot.Size = new Size(10, 15);
            label_dot.TabIndex = 4;
            label_dot.Text = ".";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(232, 149);
            numericUpDown2.Margin = new Padding(4, 3, 4, 3);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(84, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(98, 149);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label_Arvio
            // 
            label_Arvio.AutoSize = true;
            label_Arvio.Location = new Point(27, 151);
            label_Arvio.Margin = new Padding(4, 0, 4, 0);
            label_Arvio.Name = "label_Arvio";
            label_Arvio.Size = new Size(59, 15);
            label_Arvio.TabIndex = 1;
            label_Arvio.Text = "Arvosana:";
            // 
            // richTextBox_Arvio
            // 
            richTextBox_Arvio.Location = new Point(27, 17);
            richTextBox_Arvio.Margin = new Padding(4, 3, 4, 3);
            richTextBox_Arvio.Name = "richTextBox_Arvio";
            richTextBox_Arvio.Size = new Size(436, 106);
            richTextBox_Arvio.TabIndex = 0;
            richTextBox_Arvio.Text = "";
            richTextBox_Arvio.Enter += richTextBox_Arvio_Enter;
            richTextBox_Arvio.Leave += richTextBox_Arvio_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 570);
            Controls.Add(groupBox3_Arvio);
            Controls.Add(groupBox2_Toiminnallisuus);
            Controls.Add(groupBox1_ElokuvanTiedot);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Elokuvansovellus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1_ElokuvanTiedot.ResumeLayout(false);
            groupBox1_ElokuvanTiedot.PerformLayout();
            groupBox2_Toiminnallisuus.ResumeLayout(false);
            groupBox3_Arvio.ResumeLayout(false);
            groupBox3_Arvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_Kesto;
        private System.Windows.Forms.TextBox textBox_Julkaisuvuosi;
        private System.Windows.Forms.TextBox textBox_Nimi;
        private System.Windows.Forms.TextBox textBox_ID;
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
        private System.Windows.Forms.RichTextBox richTextBox_Arvio;
    }
}