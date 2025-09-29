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
            DrawTestButton = new Button();
            SuspendLayout();
            // 
            // DrawTestButton
            // 
            DrawTestButton.BackColor = Color.DarkGray;
            DrawTestButton.ForeColor = SystemColors.ButtonHighlight;
            DrawTestButton.Location = new Point(44, 42);
            DrawTestButton.Name = "DrawTestButton";
            DrawTestButton.Size = new Size(148, 59);
            DrawTestButton.TabIndex = 0;
            DrawTestButton.Text = "Draw";
            DrawTestButton.UseVisualStyleBackColor = false;
            DrawTestButton.Click += DrawTestButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(833, 470);
            Controls.Add(DrawTestButton);
            Name = "Form4";
            Text = "Test Window";
            ResumeLayout(false);
        }

        #endregion

        private Button DrawTestButton;
    }
}