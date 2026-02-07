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
            WinTextBox = new TextBox();
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // WinTextBox
            // 
            WinTextBox.BackColor = Color.DarkGray;
            WinTextBox.BorderStyle = BorderStyle.None;
            WinTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinTextBox.ForeColor = SystemColors.ButtonHighlight;
            WinTextBox.Location = new Point(368, 20);
            WinTextBox.Multiline = true;
            WinTextBox.Name = "WinTextBox";
            WinTextBox.Size = new Size(609, 373);
            WinTextBox.TabIndex = 0;
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.Gray;
            ReturnButton.ForeColor = SystemColors.ButtonHighlight;
            ReturnButton.Location = new Point(586, 438);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(178, 55);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Return To The Login";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1347, 637);
            Controls.Add(ReturnButton);
            Controls.Add(WinTextBox);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WinTextBox;
        private Button ReturnButton;
    }
}