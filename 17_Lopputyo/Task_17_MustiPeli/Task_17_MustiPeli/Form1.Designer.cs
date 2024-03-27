namespace Task_17_MustiPeli
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
            comboBox_SelectPlayerOption = new ComboBox();
            comboBox_GameSize = new ComboBox();
            comboBox_SubjectArea = new ComboBox();
            button_playMusic = new Button();
            SuspendLayout();
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Status.Location = new Point(504, 474);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(187, 28);
            label_Status.TabIndex = 0;
            label_Status.Text = "Match or MisMatch";
            // 
            // label_TimeLeft
            // 
            label_TimeLeft.AutoSize = true;
            label_TimeLeft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TimeLeft.Location = new Point(578, 19);
            label_TimeLeft.Name = "label_TimeLeft";
            label_TimeLeft.Size = new Size(137, 28);
            label_TimeLeft.TabIndex = 1;
            label_TimeLeft.Text = "Time Left: 30";
            // 
            // button_Restart
            // 
            button_Restart.BackColor = Color.Lime;
            button_Restart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Restart.Location = new Point(504, 546);
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
            label_CurrentPlayer.Location = new Point(574, 65);
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
            label_Player1.Location = new Point(249, 564);
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
            label_Player2.Location = new Point(813, 564);
            label_Player2.Name = "label_Player2";
            label_Player2.Size = new Size(89, 28);
            label_Player2.TabIndex = 5;
            label_Player2.Text = "Player 2";
            // 
            // comboBox_SelectPlayerOption
            // 
            comboBox_SelectPlayerOption.BackColor = SystemColors.Window;
            comboBox_SelectPlayerOption.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_SelectPlayerOption.FormattingEnabled = true;
            comboBox_SelectPlayerOption.Location = new Point(831, 21);
            comboBox_SelectPlayerOption.Name = "comboBox_SelectPlayerOption";
            comboBox_SelectPlayerOption.Size = new Size(209, 31);
            comboBox_SelectPlayerOption.TabIndex = 6;
            comboBox_SelectPlayerOption.Text = "Select Player Option";
            comboBox_SelectPlayerOption.SelectedIndexChanged += comboBox_SelectPlayerOption_SelectedIndexChanged;
            // 
            // comboBox_GameSize
            // 
            comboBox_GameSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_GameSize.FormattingEnabled = true;
            comboBox_GameSize.Location = new Point(831, 107);
            comboBox_GameSize.Name = "comboBox_GameSize";
            comboBox_GameSize.Size = new Size(209, 31);
            comboBox_GameSize.TabIndex = 7;
            comboBox_GameSize.Text = "Select Board Size";
            comboBox_GameSize.SelectedIndexChanged += comboBox_GameSize_SelectedIndexChanged;
            // 
            // comboBox_SubjectArea
            // 
            comboBox_SubjectArea.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_SubjectArea.FormattingEnabled = true;
            comboBox_SubjectArea.Location = new Point(831, 196);
            comboBox_SubjectArea.Name = "comboBox_SubjectArea";
            comboBox_SubjectArea.Size = new Size(209, 31);
            comboBox_SubjectArea.TabIndex = 8;
            comboBox_SubjectArea.Text = "Select Subject Area";
            comboBox_SubjectArea.SelectedIndexChanged += comboBox_SubjectArea_SelectedIndexChanged;
            // 
            // button_playMusic
            // 
            button_playMusic.BackColor = Color.FromArgb(255, 192, 192);
            button_playMusic.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_playMusic.Location = new Point(504, 366);
            button_playMusic.Name = "button_playMusic";
            button_playMusic.Size = new Size(193, 64);
            button_playMusic.TabIndex = 9;
            button_playMusic.Text = "Play Sound";
            button_playMusic.UseVisualStyleBackColor = false;
            button_playMusic.Click += button_playMusic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 643);
            Controls.Add(button_playMusic);
            Controls.Add(comboBox_SubjectArea);
            Controls.Add(comboBox_GameSize);
            Controls.Add(comboBox_SelectPlayerOption);
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
        private ComboBox comboBox_SelectPlayerOption;
        private ComboBox comboBox_GameSize;
        private ComboBox comboBox_SubjectArea;
        private Button button_playMusic;
    }
}
