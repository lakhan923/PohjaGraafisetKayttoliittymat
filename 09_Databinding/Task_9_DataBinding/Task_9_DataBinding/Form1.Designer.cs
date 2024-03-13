namespace Task_9_DataBinding
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
            label_EtuNimi = new Label();
            label_SukuNimi = new Label();
            label_Henkilöt = new Label();
            textBox_EtuNimi = new TextBox();
            textBox_SukuNimi = new TextBox();
            btn_Lisää = new Button();
            comboBox_Henkilöt = new ComboBox();
            SuspendLayout();
            // 
            // label_EtuNimi
            // 
            label_EtuNimi.AutoSize = true;
            label_EtuNimi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_EtuNimi.Location = new Point(135, 76);
            label_EtuNimi.Name = "label_EtuNimi";
            label_EtuNimi.Size = new Size(81, 28);
            label_EtuNimi.TabIndex = 0;
            label_EtuNimi.Text = "Etunimi";
            // 
            // label_SukuNimi
            // 
            label_SukuNimi.AutoSize = true;
            label_SukuNimi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_SukuNimi.Location = new Point(135, 129);
            label_SukuNimi.Name = "label_SukuNimi";
            label_SukuNimi.Size = new Size(98, 28);
            label_SukuNimi.TabIndex = 1;
            label_SukuNimi.Text = "Sukunimi";
            // 
            // label_Henkilöt
            // 
            label_Henkilöt.AutoSize = true;
            label_Henkilöt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Henkilöt.Location = new Point(135, 305);
            label_Henkilöt.Name = "label_Henkilöt";
            label_Henkilöt.Size = new Size(90, 28);
            label_Henkilöt.TabIndex = 2;
            label_Henkilöt.Text = "Henkilöt";
            // 
            // textBox_EtuNimi
            // 
            textBox_EtuNimi.Location = new Point(253, 76);
            textBox_EtuNimi.Name = "textBox_EtuNimi";
            textBox_EtuNimi.Size = new Size(171, 27);
            textBox_EtuNimi.TabIndex = 3;
            // 
            // textBox_SukuNimi
            // 
            textBox_SukuNimi.Location = new Point(253, 133);
            textBox_SukuNimi.Name = "textBox_SukuNimi";
            textBox_SukuNimi.Size = new Size(171, 27);
            textBox_SukuNimi.TabIndex = 4;
            // 
            // btn_Lisää
            // 
            btn_Lisää.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Lisää.Location = new Point(468, 127);
            btn_Lisää.Name = "btn_Lisää";
            btn_Lisää.Size = new Size(127, 41);
            btn_Lisää.TabIndex = 5;
            btn_Lisää.Text = "Lisää";
            btn_Lisää.UseVisualStyleBackColor = true;
            btn_Lisää.Click += btn_Lisää_Click;
            // 
            // comboBox_Henkilöt
            // 
            comboBox_Henkilöt.FormattingEnabled = true;
            comboBox_Henkilöt.Location = new Point(253, 305);
            comboBox_Henkilöt.Name = "comboBox_Henkilöt";
            comboBox_Henkilöt.Size = new Size(254, 28);
            comboBox_Henkilöt.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_Henkilöt);
            Controls.Add(btn_Lisää);
            Controls.Add(textBox_SukuNimi);
            Controls.Add(textBox_EtuNimi);
            Controls.Add(label_Henkilöt);
            Controls.Add(label_SukuNimi);
            Controls.Add(label_EtuNimi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label_EtuNimi;
        private Label label_SukuNimi;
        private Label label_Henkilöt;
        private TextBox textBox_EtuNimi;
        private TextBox textBox_SukuNimi;
        private Button btn_Lisää;
        private ComboBox comboBox_Henkilöt;
    }
}
