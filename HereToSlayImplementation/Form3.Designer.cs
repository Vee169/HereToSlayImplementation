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
            SlainMonster1Button = new Button();
            SlainMonster2Button = new Button();
            SlainMonster3Button = new Button();
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
            ((System.ComponentModel.ISupportInitialize)OpponentHealthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // SlainMonster1Button
            // 
            SlainMonster1Button.BackColor = Color.DarkGray;
            SlainMonster1Button.ForeColor = SystemColors.ButtonHighlight;
            SlainMonster1Button.Location = new Point(17, 1217);
            SlainMonster1Button.Margin = new Padding(4, 5, 4, 5);
            SlainMonster1Button.Name = "SlainMonster1Button";
            SlainMonster1Button.Size = new Size(379, 67);
            SlainMonster1Button.TabIndex = 1;
            SlainMonster1Button.Text = "Slain Monster 1 ";
            SlainMonster1Button.UseVisualStyleBackColor = false;
            // 
            // SlainMonster2Button
            // 
            SlainMonster2Button.BackColor = Color.DarkGray;
            SlainMonster2Button.ForeColor = SystemColors.ButtonHighlight;
            SlainMonster2Button.Location = new Point(17, 1273);
            SlainMonster2Button.Margin = new Padding(4, 5, 4, 5);
            SlainMonster2Button.Name = "SlainMonster2Button";
            SlainMonster2Button.Size = new Size(379, 67);
            SlainMonster2Button.TabIndex = 2;
            SlainMonster2Button.Text = "Slain Monster 2";
            SlainMonster2Button.UseVisualStyleBackColor = false;
            // 
            // SlainMonster3Button
            // 
            SlainMonster3Button.BackColor = Color.DarkGray;
            SlainMonster3Button.ForeColor = SystemColors.ButtonHighlight;
            SlainMonster3Button.Location = new Point(17, 1328);
            SlainMonster3Button.Margin = new Padding(4, 5, 4, 5);
            SlainMonster3Button.Name = "SlainMonster3Button";
            SlainMonster3Button.Size = new Size(379, 67);
            SlainMonster3Button.TabIndex = 3;
            SlainMonster3Button.Text = "Slain Monster 3 ";
            SlainMonster3Button.UseVisualStyleBackColor = false;
            // 
            // HandLabel
            // 
            HandLabel.AutoSize = true;
            HandLabel.ForeColor = SystemColors.ButtonHighlight;
            HandLabel.Location = new Point(597, 590);
            HandLabel.Margin = new Padding(4, 0, 4, 0);
            HandLabel.Name = "HandLabel";
            HandLabel.Size = new Size(55, 25);
            HandLabel.TabIndex = 25;
            HandLabel.Text = "Hand";
            // 
            // OpponentHealthPictureBox
            // 
            OpponentHealthPictureBox.BackColor = Color.DarkGray;
            OpponentHealthPictureBox.Location = new Point(307, 20);
            OpponentHealthPictureBox.Margin = new Padding(4, 5, 4, 5);
            OpponentHealthPictureBox.Name = "OpponentHealthPictureBox";
            OpponentHealthPictureBox.Size = new Size(809, 123);
            OpponentHealthPictureBox.TabIndex = 21;
            OpponentHealthPictureBox.TabStop = false;
            // 
            // OpponentInfoPictureBox
            // 
            OpponentInfoPictureBox.BackColor = Color.DarkGray;
            OpponentInfoPictureBox.Location = new Point(17, 20);
            OpponentInfoPictureBox.Margin = new Padding(4, 5, 4, 5);
            OpponentInfoPictureBox.Name = "OpponentInfoPictureBox";
            OpponentInfoPictureBox.Size = new Size(281, 422);
            OpponentInfoPictureBox.TabIndex = 22;
            OpponentInfoPictureBox.TabStop = false;
            // 
            // PlayerHealthPictureBox
            // 
            PlayerHealthPictureBox.BackColor = Color.DarkGray;
            PlayerHealthPictureBox.Location = new Point(809, 918);
            PlayerHealthPictureBox.Margin = new Padding(4, 5, 4, 5);
            PlayerHealthPictureBox.Name = "PlayerHealthPictureBox";
            PlayerHealthPictureBox.Size = new Size(809, 123);
            PlayerHealthPictureBox.TabIndex = 23;
            PlayerHealthPictureBox.TabStop = false;
            // 
            // PlayerInfoPictureBox
            // 
            PlayerInfoPictureBox.BackColor = Color.DarkGray;
            PlayerInfoPictureBox.Location = new Point(1626, 620);
            PlayerInfoPictureBox.Margin = new Padding(4, 5, 4, 5);
            PlayerInfoPictureBox.Name = "PlayerInfoPictureBox";
            PlayerInfoPictureBox.Size = new Size(281, 422);
            PlayerInfoPictureBox.TabIndex = 24;
            PlayerInfoPictureBox.TabStop = false;
            // 
            // PlayerDiscardButton
            // 
            PlayerDiscardButton.BackColor = Color.DimGray;
            PlayerDiscardButton.ForeColor = SystemColors.ButtonHighlight;
            PlayerDiscardButton.Location = new Point(302, 619);
            PlayerDiscardButton.Margin = new Padding(4, 5, 4, 5);
            PlayerDiscardButton.Name = "PlayerDiscardButton";
            PlayerDiscardButton.Size = new Size(281, 422);
            PlayerDiscardButton.TabIndex = 20;
            PlayerDiscardButton.Text = "Player Discard";
            PlayerDiscardButton.UseVisualStyleBackColor = false;
            PlayerDiscardButton.Click += PlayerDiscardButton_Click;
            // 
            // OpponentDeckButton
            // 
            OpponentDeckButton.BackColor = Color.DimGray;
            OpponentDeckButton.ForeColor = SystemColors.ButtonHighlight;
            OpponentDeckButton.Location = new Point(1626, 20);
            OpponentDeckButton.Margin = new Padding(4, 5, 4, 5);
            OpponentDeckButton.Name = "OpponentDeckButton";
            OpponentDeckButton.Size = new Size(281, 422);
            OpponentDeckButton.TabIndex = 19;
            OpponentDeckButton.Text = "Opponent Deck";
            OpponentDeckButton.UseVisualStyleBackColor = false;
            // 
            // PlayerDeckButton
            // 
            PlayerDeckButton.BackColor = Color.DimGray;
            PlayerDeckButton.ForeColor = SystemColors.ButtonHighlight;
            PlayerDeckButton.Location = new Point(17, 620);
            PlayerDeckButton.Margin = new Padding(0);
            PlayerDeckButton.Name = "PlayerDeckButton";
            PlayerDeckButton.Size = new Size(281, 422);
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
            TurnTextBox.Location = new Point(1133, 20);
            TurnTextBox.Multiline = true;
            TurnTextBox.Name = "TurnTextBox";
            TurnTextBox.Size = new Size(485, 123);
            TurnTextBox.TabIndex = 26;
            TurnTextBox.Text = "It is the turn of: ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1924, 1062);
            Controls.Add(TurnTextBox);
            Controls.Add(HandLabel);
            Controls.Add(OpponentHealthPictureBox);
            Controls.Add(OpponentInfoPictureBox);
            Controls.Add(PlayerHealthPictureBox);
            Controls.Add(PlayerInfoPictureBox);
            Controls.Add(PlayerDiscardButton);
            Controls.Add(OpponentDeckButton);
            Controls.Add(PlayerDeckButton);
            Controls.Add(SlainMonster1Button);
            Controls.Add(SlainMonster2Button);
            Controls.Add(SlainMonster3Button);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button SlainMonster1Button;
        private Button SlainMonster2Button;
        private Button SlainMonster3Button;
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
    }
}