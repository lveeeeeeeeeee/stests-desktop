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
            components = new System.ComponentModel.Container();
            registrationButton = new Button();
            nameBox = new TextBox();
            linkPasswordLost = new LinkLabel();
            linkSignIn = new LinkLabel();
            loginLabel = new Label();
            surnameBox = new TextBox();
            label1 = new Label();
            patronymicBox = new TextBox();
            label2 = new Label();
            requiredLabel = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            registrationButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            registrationButton.ImeMode = ImeMode.NoControl;
            registrationButton.Location = new Point(19, 350);
            registrationButton.MinimumSize = new Size(130, 54);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(310, 54);
            registrationButton.TabIndex = 13;
            registrationButton.Text = "Войти";
            registrationButton.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(19, 75);
            nameBox.MinimumSize = new Size(250, 34);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(310, 34);
            nameBox.TabIndex = 11;
            nameBox.Validating += nameBox_Validating;
            nameBox.Validated += nameBox_Validated;
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
            // surnameBox
            // 
            surnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surnameBox.Location = new Point(19, 185);
            surnameBox.MinimumSize = new Size(250, 34);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(310, 34);
            surnameBox.TabIndex = 15;
            surnameBox.Validating += surnameBox_Validating;
            surnameBox.Validated += surnameBox_Validated;
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
            // patronymicBox
            // 
            patronymicBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patronymicBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            patronymicBox.Location = new Point(19, 295);
            patronymicBox.MinimumSize = new Size(250, 34);
            patronymicBox.Name = "patronymicBox";
            patronymicBox.Size = new Size(310, 34);
            patronymicBox.TabIndex = 17;
            patronymicBox.Validating += patronymicBox_Validating;
            patronymicBox.Validated += patronymicBox_Validated;
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
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 573);
            Controls.Add(requiredLabel);
            Controls.Add(patronymicBox);
            Controls.Add(label2);
            Controls.Add(surnameBox);
            Controls.Add(label1);
            Controls.Add(registrationButton);
            Controls.Add(nameBox);
            Controls.Add(linkPasswordLost);
            Controls.Add(linkSignIn);
            Controls.Add(loginLabel);
            MaximumSize = new Size(420, 650);
            MinimumSize = new Size(380, 620);
            Name = "RegistrationForm";
            Text = "Registration - stests";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrationButton;
        private TextBox nameBox;
        private LinkLabel linkPasswordLost;
        private LinkLabel linkSignIn;
        private Label loginLabel;
        private TextBox surnameBox;
        private Label label1;
        private TextBox patronymicBox;
        private Label label2;
        private Label requiredLabel;
        private ErrorProvider errorProvider;
    }
}