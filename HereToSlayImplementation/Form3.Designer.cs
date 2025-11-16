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
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).BeginInit();
            SuspendLayout();
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
            PlayerDiscardButton.Location = new Point(301, 618);
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
            TurnTextBox.ReadOnly = true;
            TurnTextBox.Size = new Size(486, 123);
            TurnTextBox.TabIndex = 26;
            TurnTextBox.Text = "It is the turn of: ";
            // 
            // OpponentHealthTextBox
            // 
            OpponentHealthTextBox.BackColor = Color.DarkGray;
            OpponentHealthTextBox.BorderStyle = BorderStyle.None;
            OpponentHealthTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpponentHealthTextBox.ForeColor = SystemColors.ButtonHighlight;
            OpponentHealthTextBox.Location = new Point(307, 20);
            OpponentHealthTextBox.Name = "OpponentHealthTextBox";
            OpponentHealthTextBox.ReadOnly = true;
            OpponentHealthTextBox.Size = new Size(276, 120);
            OpponentHealthTextBox.TabIndex = 27;
            // 
            // OpponentDefenceTextBox
            // 
            OpponentDefenceTextBox.BackColor = Color.DarkGray;
            OpponentDefenceTextBox.BorderStyle = BorderStyle.None;
            OpponentDefenceTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpponentDefenceTextBox.ForeColor = SystemColors.ButtonHighlight;
            OpponentDefenceTextBox.Location = new Point(589, 20);
            OpponentDefenceTextBox.Name = "OpponentDefenceTextBox";
            OpponentDefenceTextBox.ReadOnly = true;
            OpponentDefenceTextBox.Size = new Size(276, 120);
            OpponentDefenceTextBox.TabIndex = 29;
            // 
            // PlayerDefenceTextBox
            // 
            PlayerDefenceTextBox.BackColor = Color.DarkGray;
            PlayerDefenceTextBox.BorderStyle = BorderStyle.None;
            PlayerDefenceTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerDefenceTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerDefenceTextBox.Location = new Point(1343, 907);
            PlayerDefenceTextBox.Name = "PlayerDefenceTextBox";
            PlayerDefenceTextBox.ReadOnly = true;
            PlayerDefenceTextBox.Size = new Size(276, 120);
            PlayerDefenceTextBox.TabIndex = 30;
            // 
            // PlayerHealthTextBox
            // 
            PlayerHealthTextBox.BackColor = Color.DarkGray;
            PlayerHealthTextBox.BorderStyle = BorderStyle.None;
            PlayerHealthTextBox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerHealthTextBox.ForeColor = SystemColors.ButtonHighlight;
            PlayerHealthTextBox.Location = new Point(1061, 907);
            PlayerHealthTextBox.Name = "PlayerHealthTextBox";
            PlayerHealthTextBox.ReadOnly = true;
            PlayerHealthTextBox.Size = new Size(276, 120);
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
            ActionPointTextBox.Location = new Point(17, 452);
            ActionPointTextBox.Margin = new Padding(4, 5, 4, 5);
            ActionPointTextBox.Name = "ActionPointTextBox";
            ActionPointTextBox.Size = new Size(131, 138);
            ActionPointTextBox.TabIndex = 32;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Gray;
            QuitButton.ForeColor = SystemColors.ButtonHighlight;
            QuitButton.Location = new Point(871, 20);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(112, 34);
            QuitButton.TabIndex = 33;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(597, 618);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(281, 422);
            button2.TabIndex = 34;
            button2.Text = "Player Discard";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            //AutoScaleDimensions = new SizeF(10F, 25F);
            //AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1924, 1062);
            Controls.Add(button2);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button2;
    }
}