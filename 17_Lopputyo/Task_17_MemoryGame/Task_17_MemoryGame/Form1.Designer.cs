namespace Task_17_MemoryGame
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
            components = new System.ComponentModel.Container();
            label_Status = new Label();
            label_TimeLeft = new Label();
            button_Restart = new Button();
            GameTimer = new System.Windows.Forms.Timer(components);
            label_CurrentPlayer = new Label();
            label_Player1 = new Label();
            label_Player2 = new Label();
            SuspendLayout();
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Status.Location = new Point(692, 95);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(187, 28);
            label_Status.TabIndex = 0;
            label_Status.Text = "Match or MisMatch";
            // 
            // label_TimeLeft
            // 
            label_TimeLeft.AutoSize = true;
            label_TimeLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TimeLeft.Location = new Point(420, 9);
            label_TimeLeft.Name = "label_TimeLeft";
            label_TimeLeft.Size = new Size(137, 28);
            label_TimeLeft.TabIndex = 1;
            label_TimeLeft.Text = "Time Left: 30";
            // 
            // button_Restart
            // 
            button_Restart.BackColor = Color.Lime;
            button_Restart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Restart.Location = new Point(371, 424);
            button_Restart.Name = "button_Restart";
            button_Restart.Size = new Size(186, 62);
            button_Restart.TabIndex = 2;
            button_Restart.Text = "Restart";
            button_Restart.UseVisualStyleBackColor = false;
            button_Restart.Click += button_Restart_Click;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // label_CurrentPlayer
            // 
            label_CurrentPlayer.AutoSize = true;
            label_CurrentPlayer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_CurrentPlayer.Location = new Point(692, 149);
            label_CurrentPlayer.Name = "label_CurrentPlayer";
            label_CurrentPlayer.Size = new Size(141, 28);
            label_CurrentPlayer.TabIndex = 3;
            label_CurrentPlayer.Text = "Current Player";
            // 
            // label_Player1
            // 
            label_Player1.AutoSize = true;
            label_Player1.BackColor = Color.FromArgb(128, 255, 255);
            label_Player1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Player1.Location = new Point(140, 442);
            label_Player1.Name = "label_Player1";
            label_Player1.Size = new Size(89, 28);
            label_Player1.TabIndex = 4;
            label_Player1.Text = "Player 1";
            // 
            // label_Player2
            // 
            label_Player2.AutoSize = true;
            label_Player2.BackColor = Color.FromArgb(255, 128, 255);
            label_Player2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Player2.Location = new Point(625, 442);
            label_Player2.Name = "label_Player2";
            label_Player2.Size = new Size(89, 28);
            label_Player2.TabIndex = 5;
            label_Player2.Text = "Player 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 517);
            Controls.Add(label_Player2);
            Controls.Add(label_Player1);
            Controls.Add(label_CurrentPlayer);
            Controls.Add(button_Restart);
            Controls.Add(label_TimeLeft);
            Controls.Add(label_Status);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Status;
        private Label label_TimeLeft;
        private Button button_Restart;
        private System.Windows.Forms.Timer GameTimer;
        private Label label_CurrentPlayer;
        private Label label_Player1;
        private Label label_Player2;
    }
}
