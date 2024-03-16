namespace Task_14_MultipleFormsApp
{
    partial class SecondaryForm
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
            label_RecievedData = new Label();
            SuspendLayout();
            // 
            // label_RecievedData
            // 
            label_RecievedData.AutoSize = true;
            label_RecievedData.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_RecievedData.Location = new Point(268, 143);
            label_RecievedData.Name = "label_RecievedData";
            label_RecievedData.Size = new Size(0, 23);
            label_RecievedData.TabIndex = 0;
            // 
            // SecondaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_RecievedData);
            Name = "SecondaryForm";
            Text = "SecondaryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_RecievedData;
    }
}