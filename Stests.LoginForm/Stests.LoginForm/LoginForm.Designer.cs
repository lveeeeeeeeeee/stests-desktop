namespace Stests.LoginForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginLabel = new Label();
            passwordLabel = new Label();
            linkSignIn = new LinkLabel();
            linkPasswordLost = new LinkLabel();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            resources.ApplyResources(loginLabel, "loginLabel");
            loginLabel.Name = "loginLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // linkSignIn
            // 
            resources.ApplyResources(linkSignIn, "linkSignIn");
            linkSignIn.Name = "linkSignIn";
            linkSignIn.TabStop = true;
            // 
            // linkPasswordLost
            // 
            resources.ApplyResources(linkPasswordLost, "linkPasswordLost");
            linkPasswordLost.Name = "linkPasswordLost";
            linkPasswordLost.TabStop = true;
            // 
            // loginBox
            // 
            resources.ApplyResources(loginBox, "loginBox");
            loginBox.Name = "loginBox";
            // 
            // passwordBox
            // 
            resources.ApplyResources(passwordBox, "passwordBox");
            passwordBox.Name = "passwordBox";
            passwordBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            resources.ApplyResources(loginButton, "loginButton");
            loginButton.Name = "loginButton";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(linkPasswordLost);
            Controls.Add(linkSignIn);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label passwordLabel;
        private LinkLabel linkSignIn;
        private LinkLabel linkPasswordLost;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button loginButton;
    }
}