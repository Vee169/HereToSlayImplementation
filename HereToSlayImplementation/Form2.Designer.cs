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
            CountdownLabel = new Label();
            GameIDLabel = new Label();
            ReadyTimer = new System.Windows.Forms.Timer(components);
            CountdownTimer = new System.Windows.Forms.Timer(components);
            SecondTimer = new System.Windows.Forms.Timer(components);
            DeckListBox = new ListBox();
            QuitButton = new Button();
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
            PlayerListBox.Location = new Point(17, 100);
            PlayerListBox.Margin = new Padding(4, 5, 4, 5);
            PlayerListBox.Name = "PlayerListBox";
            PlayerListBox.Size = new Size(907, 497);
            PlayerListBox.TabIndex = 0;
            PlayerListBox.SelectedIndexChanged += PlayerListBox_SelectedIndexChanged;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.DimGray;
            StartButton.Font = new Font("Segoe UI", 30F);
            StartButton.ForeColor = SystemColors.ButtonHighlight;
            StartButton.Location = new Point(17, 827);
            StartButton.Margin = new Padding(4, 5, 4, 5);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(310, 123);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // CountdownLabel
            // 
            CountdownLabel.AutoSize = true;
            CountdownLabel.Font = new Font("Segoe UI", 30F);
            CountdownLabel.ForeColor = SystemColors.ButtonHighlight;
            CountdownLabel.Location = new Point(336, 843);
            CountdownLabel.Margin = new Padding(4, 0, 4, 0);
            CountdownLabel.Name = "CountdownLabel";
            CountdownLabel.Size = new Size(45, 54);
            CountdownLabel.TabIndex = 2;
            CountdownLabel.Text = "5";
            // 
            // GameIDLabel
            // 
            GameIDLabel.AutoSize = true;
            GameIDLabel.Font = new Font("Segoe UI", 20F);
            GameIDLabel.ForeColor = SystemColors.ButtonHighlight;
            GameIDLabel.Location = new Point(936, 72);
            GameIDLabel.Margin = new Padding(4, 0, 4, 0);
            GameIDLabel.Name = "GameIDLabel";
            GameIDLabel.Size = new Size(183, 37);
            GameIDLabel.TabIndex = 3;
            GameIDLabel.Text = "Game code is:";
            // 
            // ReadyTimer
            // 
            ReadyTimer.Enabled = true;
            ReadyTimer.Interval = 5000;
            ReadyTimer.Tick += ReadyTimer_Tick;
            // 
            // CountdownTimer
            // 
            CountdownTimer.Interval = 5000;
            CountdownTimer.Tick += CountdownTimer_Tick;
            // 
            // SecondTimer
            // 
            SecondTimer.Interval = 1000;
            SecondTimer.Tick += SecondTimer_Tick;
            // 
            // DeckListBox
            // 
            DeckListBox.BackColor = Color.DarkGray;
            DeckListBox.BorderStyle = BorderStyle.None;
            DeckListBox.ForeColor = SystemColors.ButtonHighlight;
            DeckListBox.FormattingEnabled = true;
            DeckListBox.ItemHeight = 15;
            DeckListBox.Location = new Point(1489, 72);
            DeckListBox.Margin = new Padding(4, 5, 4, 5);
            DeckListBox.Name = "DeckListBox";
            DeckListBox.Size = new Size(419, 720);
            DeckListBox.TabIndex = 4;
            DeckListBox.SelectedIndexChanged += DeckListBox_SelectedIndexChanged;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Gray;
            QuitButton.ForeColor = SystemColors.ButtonHighlight;
            QuitButton.Location = new Point(1800, 12);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(112, 34);
            QuitButton.TabIndex = 13;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // Form2
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(1924, 1061);
            Controls.Add(QuitButton);
            Controls.Add(DeckListBox);
            Controls.Add(GameIDLabel);
            Controls.Add(CountdownLabel);
            Controls.Add(StartButton);
            Controls.Add(PlayerListBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PlayerListBox;
        private Button StartButton;
        private Label CountdownLabel;
        private Label GameIDLabel;
        private System.Windows.Forms.Timer ReadyTimer;
        private System.Windows.Forms.Timer CountdownTimer;
        private System.Windows.Forms.Timer SecondTimer;
        private ListBox DeckListBox;
        private Button QuitButton;
    }
}