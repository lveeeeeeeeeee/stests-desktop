namespace Stests.EditInfoForm
{
    partial class EditInfoForm
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
            patronymicBox = new TextBox();
            label2 = new Label();
            surnameBox = new TextBox();
            label1 = new Label();
            nameBox = new TextBox();
            loginLabel = new Label();
            requiredLabel = new Label();
            registrationButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // patronymicBox
            // 
            patronymicBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patronymicBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            patronymicBox.Location = new Point(20, 310);
            patronymicBox.MinimumSize = new Size(250, 34);
            patronymicBox.Name = "patronymicBox";
            patronymicBox.Size = new Size(310, 34);
            patronymicBox.TabIndex = 23;
            patronymicBox.Validating += patronymicBox_Validating;
            patronymicBox.Validated += patronymicBox_Validated;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(20, 260);
            label2.Name = "label2";
            label2.Size = new Size(276, 35);
            label2.TabIndex = 22;
            label2.Text = "Введите своё отчество";
            // 
            // surnameBox
            // 
            surnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surnameBox.Location = new Point(20, 200);
            surnameBox.MinimumSize = new Size(250, 34);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(310, 34);
            surnameBox.TabIndex = 21;
            surnameBox.Validating += surnameBox_Validating;
            surnameBox.Validated += surnameBox_Validated;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(20, 150);
            label1.Name = "label1";
            label1.Size = new Size(302, 35);
            label1.TabIndex = 20;
            label1.Text = "*Введите свою фамилию";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(20, 90);
            nameBox.MinimumSize = new Size(250, 34);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(310, 34);
            nameBox.TabIndex = 19;
            nameBox.Validating += nameBox_Validating;
            nameBox.Validated += nameBox_Validated;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(20, 40);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(230, 35);
            loginLabel.TabIndex = 18;
            loginLabel.Text = "*Введите своё имя";
            // 
            // requiredLabel
            // 
            requiredLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            requiredLabel.AutoSize = true;
            requiredLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            requiredLabel.Location = new Point(20, 451);
            requiredLabel.Name = "requiredLabel";
            requiredLabel.Size = new Size(293, 23);
            requiredLabel.TabIndex = 25;
            requiredLabel.Text = "*поля обязательны для заполнения";
            // 
            // registrationButton
            // 
            registrationButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            registrationButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            registrationButton.ImeMode = ImeMode.NoControl;
            registrationButton.Location = new Point(20, 381);
            registrationButton.MinimumSize = new Size(130, 54);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(310, 54);
            registrationButton.TabIndex = 24;
            registrationButton.Text = "Изменить данные";
            registrationButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EditInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 503);
            Controls.Add(requiredLabel);
            Controls.Add(registrationButton);
            Controls.Add(patronymicBox);
            Controls.Add(label2);
            Controls.Add(surnameBox);
            Controls.Add(label1);
            Controls.Add(nameBox);
            Controls.Add(loginLabel);
            MaximumSize = new Size(420, 580);
            MinimumSize = new Size(380, 550);
            Name = "EditInfoForm";
            Text = "Edit info - stests";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox patronymicBox;
        private Label label2;
        private TextBox surnameBox;
        private Label label1;
        private TextBox nameBox;
        private Label loginLabel;
        private Label requiredLabel;
        private Button registrationButton;
        private ErrorProvider errorProvider;
    }
}