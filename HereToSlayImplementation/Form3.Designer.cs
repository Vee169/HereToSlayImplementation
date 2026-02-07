namespace HereToSlayImplementation
{
    partial class Form3
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
            HandLabel = new Label();
            OpponentInfoPictureBox = new PictureBox();
            PlayerInfoPictureBox = new PictureBox();
            PlayerDiscardButton = new Button();
            OpponentDeckButton = new Button();
            PlayerDeckButton = new Button();
            MoveRetrievalTimer = new System.Windows.Forms.Timer(components);
            TurnTextBox = new TextBox();
            OpponentHealthTextBox = new TextBox();
            OpponentDefenceTextBox = new TextBox();
            PlayerDefenceTextBox = new TextBox();
            PlayerHealthTextBox = new TextBox();
            DiscardTimer = new System.Windows.Forms.Timer(components);
            ActionPointTextBox = new TextBox();
            QuitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // HandLabel
            // 
            HandLabel.AutoSize = true;
            HandLabel.ForeColor = SystemColors.ButtonHighlight;
            HandLabel.Location = new Point(413, 344);
            HandLabel.Name = "HandLabel";
            HandLabel.Size = new Size(36, 15);
            HandLabel.TabIndex = 25;
            HandLabel.Text = "Hand";
            // 
            // OpponentInfoPictureBox
            // 
            OpponentInfoPictureBox.BackColor = Color.DarkGray;
            OpponentInfoPictureBox.Location = new Point(12, 12);
            OpponentInfoPictureBox.Name = "OpponentInfoPictureBox";
            OpponentInfoPictureBox.Size = new Size(197, 253);
            OpponentInfoPictureBox.TabIndex = 22;
            OpponentInfoPictureBox.TabStop = false;
            // 
            // PlayerInfoPictureBox
            // 
            PlayerInfoPictureBox.BackColor = Color.DarkGray;
            PlayerInfoPictureBox.Location = new Point(1138, 372);
            PlayerInfoPictureBox.Name = "PlayerInfoPictureBox";
            PlayerInfoPictureBox.Size = new Size(197, 253);
            PlayerInfoPictureBox.TabIndex = 24;
            PlayerInfoPictureBox.TabStop = false;
            // 
            // PlayerDiscardButton
            // 
            PlayerDiscardButton.BackColor = Color.DimGray;
            PlayerDiscardButton.ForeColor = SystemColors.ButtonHighlight;
            PlayerDiscardButton.Location = new Point(211, 371);
            PlayerDiscardButton.Name = "PlayerDiscardButton";
            PlayerDiscardButton.Size = new Size(197, 253);
            PlayerDiscardButton.TabIndex = 20;
            PlayerDiscardButton.Text = "Player Discard";
            PlayerDiscardButton.UseVisualStyleBackColor = false;
            PlayerDiscardButton.Click += PlayerDiscardButton_Click;
            // 
            // OpponentDeckButton
            // 
            OpponentDeckButton.BackColor = Color.DimGray;
            OpponentDeckButton.ForeColor = SystemColors.ButtonHighlight;
            OpponentDeckButton.Location = new Point(1138, 12);
            OpponentDeckButton.Name = "OpponentDeckButton";
            OpponentDeckButton.Size = new Size(197, 253);
            OpponentDeckButton.TabIndex = 19;
            OpponentDeckButton.Text = "Opponent Deck";
            OpponentDeckButton.UseVisualStyleBackColor = false;
            // 
            // PlayerDeckButton
            // 
            PlayerDeckButton.BackColor = Color.DimGray;
            PlayerDeckButton.ForeColor = SystemColors.ButtonHighlight;
            PlayerDeckButton.Location = new Point(12, 372);
            PlayerDeckButton.Margin = new Padding(0);
            PlayerDeckButton.Name = "PlayerDeckButton";
            PlayerDeckButton.Size = new Size(197, 253);
            PlayerDeckButton.TabIndex = 18;
            PlayerDeckButton.Text = "Player Deck";
            PlayerDeckButton.UseVisualStyleBackColor = false;
            PlayerDeckButton.Click += PlayerDeckButton_Click;
            // 
            // MoveRetrievalTimer
            // 
            MoveRetrievalTimer.Interval = 1000;
            MoveRetrievalTimer.Tick += MoveRetrievalTimer_Tick;
            // 
            // TurnTextBox
            // 
            TurnTextBox.BackColor = Color.Gray;
            TurnTextBox.BorderStyle = BorderStyle.None;
            TurnTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TurnTextBox.ForeColor = SystemColors.ButtonHighlight;
            TurnTextBox.Location = new Point(793, 12);
            TurnTextBox.Margin = new Padding(2);
            TurnTextBox.Multiline = true;
            TurnTextBox.Name = "TurnTextBox";
            TurnTextBox.ReadOnly = true;
            TurnTextBox.Size = new Size(340, 74);
            TurnTextBox.TabIndex = 26;
            TurnTextBox.Text = "It is the turn of: ";
            // 
            // OpponentHealthTextBox
            // 
            OpponentHealthTextBox.BackColor = Color.DarkGray;
            OpponentHealthTextBox.BorderStyle = BorderStyle.None;
            OpponentHealthTextBox.Font = new Font("Segoe UI", 30F);
            OpponentHealthTextBox.ForeColor = SystemColors.ButtonHighlight;
            OpponentHealthTextBox.Location = new Point(215, 12);
            OpponentHealthTextBox.Margin = new Padding(2);
            OpponentHealthTextBox.Multiline = true;
            OpponentHealthTextBox.Name = "OpponentHealthTextBox";
            OpponentHealthTextBox.ReadOnly = true;
            OpponentHealthTextBox.Size = new Size(193, 80);
            OpponentHealthTextBox.TabIndex = 27;
            // 
            // OpponentDefenceTextBox
            // 
            OpponentDefenceTextBox.BackColor = Color.DarkGray;
            OpponentDefenceTextBox.BorderStyle = BorderStyle.None;
            OpponentDefenceTextBox.Font = new Font("Segoe UI", 30F);
            OpponentDefenceTextBox.ForeColor = SystemColors.ButtonHighlight;
            OpponentDefenceTextBox.Location = new Point(412, 12);
            OpponentDefenceTextBox.Margin = new Padding(2);
            OpponentDefenceTextBox.Multiline = true;
            OpponentDefenceTextBox.Name = "OpponentDefenceTextBox";
            OpponentDefenceTextBox.ReadOnly = true;
            OpponentDefenceTextBox.Size = new Size(193, 80);
            OpponentDefenceTextBox.TabIndex = 29;
            // 
            // PlayerDefenceTextBox
            // 
            PlayerDefenceTextBox.BackColor = Color.DarkGray;
            PlayerDefenceTextBox.BorderStyle = BorderStyle.None;
            PlayerDefenceTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerDefenceTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerDefenceTextBox.Location = new Point(940, 544);
            PlayerDefenceTextBox.Margin = new Padding(2);
            PlayerDefenceTextBox.Multiline = true;
            PlayerDefenceTextBox.Name = "PlayerDefenceTextBox";
            PlayerDefenceTextBox.ReadOnly = true;
            PlayerDefenceTextBox.Size = new Size(193, 80);
            PlayerDefenceTextBox.TabIndex = 30;
            // 
            // PlayerHealthTextBox
            // 
            PlayerHealthTextBox.BackColor = Color.DarkGray;
            PlayerHealthTextBox.BorderStyle = BorderStyle.None;
            PlayerHealthTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerHealthTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerHealthTextBox.Location = new Point(743, 544);
            PlayerHealthTextBox.Margin = new Padding(2);
            PlayerHealthTextBox.Name = "PlayerHealthTextBox";
            PlayerHealthTextBox.ReadOnly = true;
            PlayerHealthTextBox.Size = new Size(193, 54);
            PlayerHealthTextBox.TabIndex = 31;
            // 
            // DiscardTimer
            // 
            DiscardTimer.Interval = 3000;
            DiscardTimer.Tick += DiscardTimer_Tick;
            // 
            // ActionPointTextBox
            // 
            ActionPointTextBox.BackColor = Color.DarkGray;
            ActionPointTextBox.BorderStyle = BorderStyle.None;
            ActionPointTextBox.Font = new Font("Segoe UI", 51.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActionPointTextBox.ForeColor = SystemColors.ButtonHighlight;
            ActionPointTextBox.Location = new Point(12, 271);
            ActionPointTextBox.Multiline = true;
            ActionPointTextBox.Name = "ActionPointTextBox";
            ActionPointTextBox.Size = new Size(92, 92);
            ActionPointTextBox.TabIndex = 32;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Gray;
            QuitButton.ForeColor = SystemColors.ButtonHighlight;
            QuitButton.Location = new Point(610, 12);
            QuitButton.Margin = new Padding(2);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(78, 41);
            QuitButton.TabIndex = 33;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // Form3
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(1347, 637);
            Controls.Add(QuitButton);
            Controls.Add(ActionPointTextBox);
            Controls.Add(PlayerHealthTextBox);
            Controls.Add(PlayerDefenceTextBox);
            Controls.Add(OpponentDefenceTextBox);
            Controls.Add(OpponentHealthTextBox);
            Controls.Add(TurnTextBox);
            Controls.Add(HandLabel);
            Controls.Add(OpponentInfoPictureBox);
            Controls.Add(PlayerInfoPictureBox);
            Controls.Add(PlayerDiscardButton);
            Controls.Add(OpponentDeckButton);
            Controls.Add(PlayerDeckButton);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button8;
        private Button button10;
        private Label HandLabel;
        private PictureBox OpponentInfoPictureBox;
        private PictureBox PlayerInfoPictureBox;
        private Button PlayerDiscardButton;
        private Button OpponentDeckButton;
        private Button PlayerDeckButton;
        private System.Windows.Forms.Timer MoveRetrievalTimer;
        private TextBox TurnTextBox;
        private TextBox OpponentHealthTextBox;
        private TextBox OpponentDefenceTextBox;
        private TextBox PlayerDefenceTextBox;
        private TextBox PlayerHealthTextBox;
        private System.Windows.Forms.Timer DiscardTimer;
        private TextBox ActionPointTextBox;
        private Button QuitButton;
    }
}