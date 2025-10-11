namespace HereToSlayImplementation
{
    partial class Form4
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
            OpponentHealthPictureBox = new PictureBox();
            PlayerInfoPictureBox = new PictureBox();
            PlayerHealthPictureBox = new PictureBox();
            OpponentInfoPictureBox = new PictureBox();
            PlayerDeckButton = new Button();
            PlayerDiscarButton = new Button();
            OpponentHandButton = new Button();
            HandLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OpponentHealthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // OpponentHealthPictureBox
            // 
            OpponentHealthPictureBox.BackColor = Color.DarkGray;
            OpponentHealthPictureBox.Location = new Point(215, 12);
            OpponentHealthPictureBox.Name = "OpponentHealthPictureBox";
            OpponentHealthPictureBox.Size = new Size(618, 58);
            OpponentHealthPictureBox.TabIndex = 0;
            OpponentHealthPictureBox.TabStop = false;
            // 
            // PlayerInfoPictureBox
            // 
            PlayerInfoPictureBox.BackColor = Color.DarkGray;
            PlayerInfoPictureBox.Location = new Point(1138, 372);
            PlayerInfoPictureBox.Name = "PlayerInfoPictureBox";
            PlayerInfoPictureBox.Size = new Size(197, 253);
            PlayerInfoPictureBox.TabIndex = 1;
            PlayerInfoPictureBox.TabStop = false;
            // 
            // PlayerHealthPictureBox
            // 
            PlayerHealthPictureBox.BackColor = Color.DarkGray;
            PlayerHealthPictureBox.Location = new Point(514, 567);
            PlayerHealthPictureBox.Name = "PlayerHealthPictureBox";
            PlayerHealthPictureBox.Size = new Size(618, 58);
            PlayerHealthPictureBox.TabIndex = 2;
            PlayerHealthPictureBox.TabStop = false;
            // 
            // OpponentInfoPictureBox
            // 
            OpponentInfoPictureBox.BackColor = Color.DarkGray;
            OpponentInfoPictureBox.Location = new Point(12, 12);
            OpponentInfoPictureBox.Name = "OpponentInfoPictureBox";
            OpponentInfoPictureBox.Size = new Size(197, 253);
            OpponentInfoPictureBox.TabIndex = 3;
            OpponentInfoPictureBox.TabStop = false;
            // 
            // PlayerDeckButton
            // 
            PlayerDeckButton.BackColor = Color.DimGray;
            PlayerDeckButton.ForeColor = SystemColors.ButtonHighlight;
            PlayerDeckButton.Location = new Point(12, 372);
            PlayerDeckButton.Name = "PlayerDeckButton";
            PlayerDeckButton.Size = new Size(197, 253);
            PlayerDeckButton.TabIndex = 4;
            PlayerDeckButton.Text = "Player Deck";
            PlayerDeckButton.UseVisualStyleBackColor = false;
            // 
            // PlayerDiscarButton
            // 
            PlayerDiscarButton.BackColor = Color.DimGray;
            PlayerDiscarButton.ForeColor = SystemColors.ButtonHighlight;
            PlayerDiscarButton.Location = new Point(215, 372);
            PlayerDiscarButton.Name = "PlayerDiscarButton";
            PlayerDiscarButton.Size = new Size(197, 253);
            PlayerDiscarButton.TabIndex = 5;
            PlayerDiscarButton.Text = "Player Discard";
            PlayerDiscarButton.UseVisualStyleBackColor = false;
            // 
            // OpponentHandButton
            // 
            OpponentHandButton.BackColor = Color.DimGray;
            OpponentHandButton.ForeColor = SystemColors.ButtonHighlight;
            OpponentHandButton.Location = new Point(1138, 12);
            OpponentHandButton.Name = "OpponentHandButton";
            OpponentHandButton.Size = new Size(197, 253);
            OpponentHandButton.TabIndex = 6;
            OpponentHandButton.Text = "Player Deck";
            OpponentHandButton.UseVisualStyleBackColor = false;
            // 
            // HandLabel
            // 
            HandLabel.AutoSize = true;
            HandLabel.BackColor = Color.Gray;
            HandLabel.ForeColor = SystemColors.ButtonHighlight;
            HandLabel.Location = new Point(416, 356);
            HandLabel.Name = "HandLabel";
            HandLabel.Size = new Size(36, 15);
            HandLabel.TabIndex = 7;
            HandLabel.Text = "Hand";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1347, 637);
            Controls.Add(HandLabel);
            Controls.Add(OpponentHandButton);
            Controls.Add(PlayerDiscarButton);
            Controls.Add(PlayerDeckButton);
            Controls.Add(OpponentInfoPictureBox);
            Controls.Add(PlayerHealthPictureBox);
            Controls.Add(PlayerInfoPictureBox);
            Controls.Add(OpponentHealthPictureBox);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)OpponentHealthPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerInfoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpponentInfoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox OpponentHealthPictureBox;
        private PictureBox PlayerInfoPictureBox;
        private PictureBox PlayerHealthPictureBox;
        private PictureBox OpponentInfoPictureBox;
        private Button PlayerDeckButton;
        private Button PlayerDiscarButton;
        private Button OpponentHandButton;
        private Label HandLabel;
    }
}