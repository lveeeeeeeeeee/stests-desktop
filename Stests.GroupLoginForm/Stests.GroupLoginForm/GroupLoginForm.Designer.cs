﻿namespace Stests.GroupLoginForm
{
    partial class GroupLoginForm
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
            loginButton = new Button();
            passwordBox = new TextBox();
            loginBox = new TextBox();
            passwordLabel = new Label();
            loginLabel = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ImeMode = ImeMode.NoControl;
            loginButton.Location = new Point(20, 220);
            loginButton.MinimumSize = new Size(310, 54);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(310, 54);
            loginButton.TabIndex = 13;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(20, 165);
            passwordBox.MinimumSize = new Size(310, 34);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(310, 34);
            passwordBox.TabIndex = 12;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(20, 65);
            loginBox.MinimumSize = new Size(310, 34);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(310, 34);
            loginBox.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ImeMode = ImeMode.NoControl;
            passwordLabel.Location = new Point(20, 120);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(287, 35);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Введите пароль группы";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(20, 20);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(310, 35);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Введите название группы";
            loginLabel.Click += loginLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 303);
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            MaximumSize = new Size(450, 350);
            MinimumSize = new Size(370, 350);
            Name = "Form1";
            Text = "Log in group - stests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox passwordBox;
        private TextBox loginBox;
        private Label passwordLabel;
        private Label loginLabel;
    }
}