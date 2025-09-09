namespace HereToSlayImplementation
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            PlayerListBox = new ListBox();
            StartButton = new Button();
            CountDownLabel = new Label();
            GameIDLabel = new Label();
            ReadyTimer = new System.Windows.Forms.Timer(components);
            CountdownTimer = new System.Windows.Forms.Timer(components);
            SecondTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // PlayerListBox
            // 
            PlayerListBox.BackColor = Color.Gray;
            PlayerListBox.BorderStyle = BorderStyle.None;
            PlayerListBox.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerListBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerListBox.FormattingEnabled = true;
            PlayerListBox.ItemHeight = 71;
            PlayerListBox.Location = new Point(12, 60);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(635, 426);
            PlayerListBox.TabIndex = 0;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.DimGray;
            StartButton.Font = new Font("Segoe UI", 30F);
            StartButton.ForeColor = SystemColors.ButtonHighlight;
            StartButton.Location = new Point(12, 496);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(217, 74);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            // 
            // CountDownLabel
            // 
            CountDownLabel.AutoSize = true;
            CountDownLabel.Font = new Font("Segoe UI", 30F);
            CountDownLabel.ForeColor = SystemColors.ButtonHighlight;
            CountDownLabel.Location = new Point(235, 506);
            CountDownLabel.Name = "CountDownLabel";
            CountDownLabel.Size = new Size(45, 54);
            CountDownLabel.TabIndex = 2;
            CountDownLabel.Text = "5";
            // 
            // GameIDLabel
            // 
            GameIDLabel.AutoSize = true;
            GameIDLabel.Font = new Font("Segoe UI", 20F);
            GameIDLabel.ForeColor = SystemColors.ButtonHighlight;
            GameIDLabel.Location = new Point(655, 43);
            GameIDLabel.Name = "GameIDLabel";
            GameIDLabel.Size = new Size(183, 37);
            GameIDLabel.TabIndex = 3;
            GameIDLabel.Text = "Game code is:";
            // 
            // ReadyTimer
            // 
            ReadyTimer.Enabled = true;
            ReadyTimer.Interval = 5000;
            // 
            // CountdownTimer
            // 
            CountdownTimer.Interval = 5000;
            // 
            // SecondTimer
            // 
            SecondTimer.Interval = 1000;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1472, 650);
            Controls.Add(GameIDLabel);
            Controls.Add(CountDownLabel);
            Controls.Add(StartButton);
            Controls.Add(PlayerListBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PlayerListBox;
        private Button StartButton;
        private Label CountDownLabel;
        private Label GameIDLabel;
        private System.Windows.Forms.Timer ReadyTimer;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Timer SecondTimer;
    }
}