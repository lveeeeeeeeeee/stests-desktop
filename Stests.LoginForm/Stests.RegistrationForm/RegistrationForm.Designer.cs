namespace Stests.RegistrationForm
{
    partial class RegistrationForm
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
            loginBox = new TextBox();
            linkPasswordLost = new LinkLabel();
            linkSignIn = new LinkLabel();
            loginLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            requiredLabel = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ImeMode = ImeMode.NoControl;
            loginButton.Location = new Point(19, 350);
            loginButton.MinimumSize = new Size(130, 54);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(310, 54);
            loginButton.TabIndex = 13;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(19, 75);
            loginBox.MinimumSize = new Size(250, 34);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(310, 34);
            loginBox.TabIndex = 11;
            // 
            // linkPasswordLost
            // 
            linkPasswordLost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkPasswordLost.AutoSize = true;
            linkPasswordLost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkPasswordLost.ImeMode = ImeMode.NoControl;
            linkPasswordLost.Location = new Point(19, 523);
            linkPasswordLost.Name = "linkPasswordLost";
            linkPasswordLost.Size = new Size(157, 28);
            linkPasswordLost.TabIndex = 10;
            linkPasswordLost.TabStop = true;
            linkPasswordLost.Text = "Пароль утерян?";
            // 
            // linkSignIn
            // 
            linkSignIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkSignIn.AutoSize = true;
            linkSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkSignIn.ImeMode = ImeMode.NoControl;
            linkSignIn.Location = new Point(19, 480);
            linkSignIn.Name = "linkSignIn";
            linkSignIn.Size = new Size(220, 28);
            linkSignIn.TabIndex = 9;
            linkSignIn.TabStop = true;
            linkSignIn.Text = "Не нужна регистрация";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(19, 25);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(230, 35);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "*Введите своё имя";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(19, 185);
            textBox1.MinimumSize = new Size(250, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 34);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(19, 135);
            label1.Name = "label1";
            label1.Size = new Size(302, 35);
            label1.TabIndex = 14;
            label1.Text = "*Введите свою фамилию";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(19, 295);
            textBox2.MinimumSize = new Size(250, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 34);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(19, 245);
            label2.Name = "label2";
            label2.Size = new Size(276, 35);
            label2.TabIndex = 16;
            label2.Text = "Введите своё отчество";
            // 
            // requiredLabel
            // 
            requiredLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            requiredLabel.AutoSize = true;
            requiredLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            requiredLabel.Location = new Point(19, 420);
            requiredLabel.Name = "requiredLabel";
            requiredLabel.Size = new Size(293, 23);
            requiredLabel.TabIndex = 18;
            requiredLabel.Text = "*поля обязательны для заполнения";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 573);
            Controls.Add(requiredLabel);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(loginButton);
            Controls.Add(loginBox);
            Controls.Add(linkPasswordLost);
            Controls.Add(linkSignIn);
            Controls.Add(loginLabel);
            MaximumSize = new Size(420, 650);
            MinimumSize = new Size(380, 620);
            Name = "RegistrationForm";
            Text = "Registration - stests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox loginBox;
        private LinkLabel linkPasswordLost;
        private LinkLabel linkSignIn;
        private Label loginLabel;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label requiredLabel;
    }
}