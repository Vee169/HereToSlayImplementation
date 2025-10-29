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
            OpponentHealthPictureBox = new PictureBox();
            OpponentInfoPictureBox = new PictureBox();
            PlayerHealthPictureBox = new PictureBox();
            PlayerInfoPictureBox = new PictureBox();
            PlayerDiscardButton = new Button();
            OpponentDeckButton = new Button();
            PlayerDeckButton = new Button();
            MoveRetrievalTimer = new System.Windows.Forms.Timer(components);
            TurnTextBox = new TextBox();
            DiscardTimer = new System.Windows.Forms.Timer(components);
            OpponentHealthTextBox = new TextBox();
            OpponentDefenceTextBox = new TextBox();
            PlayerDefenceTextBox = new TextBox();
            PlayerHealthTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OpponentHealthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // HandLabel
            // 
            HandLabel.AutoSize = true;
            HandLabel.ForeColor = SystemColors.ButtonHighlight;
            HandLabel.Location = new Point(418, 354);
            HandLabel.Name = "HandLabel";
            HandLabel.Size = new Size(36, 15);
            HandLabel.TabIndex = 25;
            HandLabel.Text = "Hand";
            // 
            // OpponentHealthPictureBox
            // 
            OpponentHealthPictureBox.BackColor = Color.DarkGray;
            OpponentHealthPictureBox.Location = new Point(215, 12);
            OpponentHealthPictureBox.Name = "OpponentHealthPictureBox";
            OpponentHealthPictureBox.Size = new Size(566, 74);
            OpponentHealthPictureBox.TabIndex = 21;
            OpponentHealthPictureBox.TabStop = false;
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
            // PlayerHealthPictureBox
            // 
            PlayerHealthPictureBox.BackColor = Color.DarkGray;
            PlayerHealthPictureBox.Location = new Point(566, 551);
            PlayerHealthPictureBox.Name = "PlayerHealthPictureBox";
            PlayerHealthPictureBox.Size = new Size(566, 74);
            PlayerHealthPictureBox.TabIndex = 23;
            PlayerHealthPictureBox.TabStop = false;
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
            // DiscardTimer
            // 
            DiscardTimer.Interval = 1000;
            DiscardTimer.Tick += DiscardTimer_Tick;
            // 
            // OpponentHealthTextBox
            // 
            OpponentHealthTextBox.BackColor = Color.DarkGray;
            OpponentHealthTextBox.BorderStyle = BorderStyle.None;
            OpponentHealthTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpponentHealthTextBox.ForeColor = SystemColors.ButtonHighlight;
            OpponentHealthTextBox.Location = new Point(215, 12);
            OpponentHealthTextBox.Margin = new Padding(2);
            OpponentHealthTextBox.Name = "OpponentHealthTextBox";
            OpponentHealthTextBox.ReadOnly = true;
            OpponentHealthTextBox.Size = new Size(193, 80);
            OpponentHealthTextBox.TabIndex = 27;
            // 
            // OpponentDefenceTextBox
            // 
            OpponentDefenceTextBox.BackColor = Color.DarkGray;
            OpponentDefenceTextBox.BorderStyle = BorderStyle.None;
            OpponentDefenceTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpponentDefenceTextBox.ForeColor = SystemColors.ButtonHighlight;
            OpponentDefenceTextBox.Location = new Point(412, 11);
            OpponentDefenceTextBox.Margin = new Padding(2);
            OpponentDefenceTextBox.Name = "OpponentDefenceTextBox";
            OpponentDefenceTextBox.ReadOnly = true;
            OpponentDefenceTextBox.Size = new Size(193, 80);
            OpponentDefenceTextBox.TabIndex = 29;
            // 
            // PlayerDefenceTextBox
            // 
            PlayerDefenceTextBox.BackColor = Color.DarkGray;
            PlayerDefenceTextBox.BorderStyle = BorderStyle.None;
            PlayerDefenceTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerDefenceTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerDefenceTextBox.Location = new Point(763, 544);
            PlayerDefenceTextBox.Margin = new Padding(2);
            PlayerDefenceTextBox.Name = "PlayerDefenceTextBox";
            PlayerDefenceTextBox.ReadOnly = true;
            PlayerDefenceTextBox.Size = new Size(193, 80);
            PlayerDefenceTextBox.TabIndex = 30;
            // 
            // PlayerHealthTextBox
            // 
            PlayerHealthTextBox.BackColor = Color.DarkGray;
            PlayerHealthTextBox.BorderStyle = BorderStyle.None;
            PlayerHealthTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerHealthTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerHealthTextBox.Location = new Point(566, 544);
            PlayerHealthTextBox.Margin = new Padding(2);
            PlayerHealthTextBox.Name = "PlayerHealthTextBox";
            PlayerHealthTextBox.ReadOnly = true;
            PlayerHealthTextBox.Size = new Size(193, 80);
            PlayerHealthTextBox.TabIndex = 31;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1347, 637);
            Controls.Add(PlayerHealthTextBox);
            Controls.Add(PlayerDefenceTextBox);
            Controls.Add(OpponentDefenceTextBox);
            Controls.Add(OpponentHealthTextBox);
            Controls.Add(TurnTextBox);
            Controls.Add(HandLabel);
            Controls.Add(OpponentHealthPictureBox);
            Controls.Add(OpponentInfoPictureBox);
            Controls.Add(PlayerHealthPictureBox);
            Controls.Add(PlayerInfoPictureBox);
            Controls.Add(PlayerDiscardButton);
            Controls.Add(OpponentDeckButton);
            Controls.Add(PlayerDeckButton);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)OpponentHealthPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthPictureBox).EndInit();
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
        private PictureBox OpponentHealthPictureBox;
        private PictureBox OpponentInfoPictureBox;
        private PictureBox PlayerHealthPictureBox;
        private PictureBox PlayerInfoPictureBox;
        private Button PlayerDiscardButton;
        private Button OpponentDeckButton;
        private Button PlayerDeckButton;
        private System.Windows.Forms.Timer MoveRetrievalTimer;
        private TextBox TurnTextBox;
        private System.Windows.Forms.Timer DiscardTimer;
        private TextBox OpponentHealthTextBox;
        private TextBox OpponentDefenceTextBox;
        private TextBox PlayerDefenceTextBox;
        private TextBox PlayerHealthTextBox;
    }
}