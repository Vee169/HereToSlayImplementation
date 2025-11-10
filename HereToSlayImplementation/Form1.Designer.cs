namespace HereToSlayImplementation
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
            LoginButton = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUpButton = new Button();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            AccountMessageTextBox = new TextBox();
            HostButton = new Button();
            JoinTextBox = new TextBox();
            JoinButton = new Button();
            JoinWarningTextBox = new TextBox();
            Testbutton = new Button();
            QuitButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DimGray;
            LoginButton.ForeColor = SystemColors.ButtonHighlight;
            LoginButton.Location = new Point(1713, 163);
            LoginButton.Margin = new Padding(4, 5, 4, 5);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(143, 38);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.DarkGray;
            UsernameTextBox.BorderStyle = BorderStyle.None;
            UsernameTextBox.ForeColor = SystemColors.ButtonHighlight;
            UsernameTextBox.Location = new Point(1713, 127);
            UsernameTextBox.Margin = new Padding(4, 5, 4, 5);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(143, 24);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.DarkGray;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.ForeColor = SystemColors.ButtonHighlight;
            PasswordTextBox.Location = new Point(1864, 127);
            PasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(143, 24);
            PasswordTextBox.TabIndex = 2;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.DimGray;
            SignUpButton.ForeColor = SystemColors.ButtonHighlight;
            SignUpButton.Location = new Point(1864, 163);
            SignUpButton.Margin = new Padding(4, 5, 4, 5);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(143, 38);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.ForeColor = SystemColors.ButtonHighlight;
            UsernameLabel.Location = new Point(1713, 97);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(91, 25);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = SystemColors.ButtonHighlight;
            PasswordLabel.Location = new Point(1864, 97);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // AccountMessageTextBox
            // 
            AccountMessageTextBox.BackColor = Color.Gray;
            AccountMessageTextBox.BorderStyle = BorderStyle.None;
            AccountMessageTextBox.ForeColor = SystemColors.ButtonHighlight;
            AccountMessageTextBox.Location = new Point(1713, 212);
            AccountMessageTextBox.Margin = new Padding(4, 5, 4, 5);
            AccountMessageTextBox.Multiline = true;
            AccountMessageTextBox.Name = "AccountMessageTextBox";
            AccountMessageTextBox.Size = new Size(294, 68);
            AccountMessageTextBox.TabIndex = 6;
            // 
            // HostButton
            // 
            HostButton.BackColor = Color.DimGray;
            HostButton.Font = new Font("Segoe UI", 20F);
            HostButton.ForeColor = SystemColors.ButtonHighlight;
            HostButton.Location = new Point(919, 332);
            HostButton.Margin = new Padding(4, 5, 4, 5);
            HostButton.Name = "HostButton";
            HostButton.Size = new Size(266, 120);
            HostButton.TabIndex = 7;
            HostButton.Text = "Host";
            HostButton.UseVisualStyleBackColor = false;
            HostButton.Click += HostButton_Click;
            // 
            // JoinTextBox
            // 
            JoinTextBox.BackColor = Color.DarkGray;
            JoinTextBox.BorderStyle = BorderStyle.None;
            JoinTextBox.Location = new Point(919, 462);
            JoinTextBox.Margin = new Padding(4, 5, 4, 5);
            JoinTextBox.Name = "JoinTextBox";
            JoinTextBox.Size = new Size(266, 24);
            JoinTextBox.TabIndex = 8;
            // 
            // JoinButton
            // 
            JoinButton.BackColor = Color.DimGray;
            JoinButton.Font = new Font("Segoe UI", 20F);
            JoinButton.ForeColor = SystemColors.ButtonHighlight;
            JoinButton.Location = new Point(919, 498);
            JoinButton.Margin = new Padding(4, 5, 4, 5);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(266, 120);
            JoinButton.TabIndex = 9;
            JoinButton.Text = "Join";
            JoinButton.UseVisualStyleBackColor = false;
            JoinButton.Click += JoinButton_Click;
            // 
            // JoinWarningTextBox
            // 
            JoinWarningTextBox.BackColor = Color.Gray;
            JoinWarningTextBox.BorderStyle = BorderStyle.None;
            JoinWarningTextBox.Location = new Point(919, 628);
            JoinWarningTextBox.Margin = new Padding(4, 5, 4, 5);
            JoinWarningTextBox.Name = "JoinWarningTextBox";
            JoinWarningTextBox.ReadOnly = true;
            JoinWarningTextBox.Size = new Size(266, 24);
            JoinWarningTextBox.TabIndex = 10;
            // 
            // Testbutton
            // 
            Testbutton.Location = new Point(1163, 162);
            Testbutton.Name = "Testbutton";
            Testbutton.Size = new Size(74, 23);
            Testbutton.TabIndex = 11;
            Testbutton.Text = "Test";
            Testbutton.UseVisualStyleBackColor = true;
            Testbutton.Click += Testbutton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Gray;
            QuitButton.ForeColor = SystemColors.ButtonHighlight;
            QuitButton.Location = new Point(1935, 12);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(112, 34);
            QuitButton.TabIndex = 12;
            QuitButton.Text = "Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(2059, 1062);
            Controls.Add(QuitButton);
            Controls.Add(Testbutton);
            Controls.Add(JoinWarningTextBox);
            Controls.Add(JoinButton);
            Controls.Add(JoinTextBox);
            Controls.Add(HostButton);
            Controls.Add(AccountMessageTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(SignUpButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(LoginButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button SignUpButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox AccountMessageTextBox;
        private Button HostButton;
        private TextBox JoinTextBox;
        private Button JoinButton;
        private TextBox JoinWarningTextBox;
        private Button Testbutton;
        private Button QuitButton;
    }
}
