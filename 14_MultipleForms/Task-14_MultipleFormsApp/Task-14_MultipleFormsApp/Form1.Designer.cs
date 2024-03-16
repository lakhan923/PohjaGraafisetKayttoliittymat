namespace Task_14_MultipleFormsApp
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
            button_OpenSecondaryForm = new Button();
            SuspendLayout();
            // 
            // button_OpenSecondaryForm
            // 
            button_OpenSecondaryForm.BackColor = Color.Lime;
            button_OpenSecondaryForm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_OpenSecondaryForm.Location = new Point(247, 169);
            button_OpenSecondaryForm.Name = "button_OpenSecondaryForm";
            button_OpenSecondaryForm.Size = new Size(274, 60);
            button_OpenSecondaryForm.TabIndex = 0;
            button_OpenSecondaryForm.Text = "Click To Open Secondary Form";
            button_OpenSecondaryForm.UseVisualStyleBackColor = false;
            button_OpenSecondaryForm.Click += button_OpenSecondaryForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_OpenSecondaryForm);
            Name = "Form1";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button_OpenSecondaryForm;
    }
}
