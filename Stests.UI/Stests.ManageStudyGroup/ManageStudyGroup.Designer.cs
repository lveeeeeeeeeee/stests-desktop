namespace Stests.ManageStudyGroup
{
    partial class ManageStudyGroup
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
            errorProvider = new ErrorProvider(components);
            passwordBox = new TextBox();
            nameBox = new TextBox();
            groupNameLabel = new Label();
            groupPasswordLabel = new Label();
            changeGroupNameButton = new Button();
            displayUsersControl1 = new DisplayUsersInGroupControl.DisplayUsersControl();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Bottom;
            passwordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(470, 400);
            passwordBox.Name = "passwordBox";
            passwordBox.ReadOnly = true;
            passwordBox.Size = new Size(192, 34);
            passwordBox.TabIndex = 0;
            passwordBox.Text = "proverka123";
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.KeyDown += passwordBox_KeyDown;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Bottom;
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(20, 400);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(215, 34);
            nameBox.TabIndex = 1;
            nameBox.Validating += nameBox_Validating;
            nameBox.Validated += nameBox_Validated;
            // 
            // groupNameLabel
            // 
            groupNameLabel.Anchor = AnchorStyles.Bottom;
            groupNameLabel.AutoSize = true;
            groupNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupNameLabel.Location = new Point(20, 350);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new Size(215, 35);
            groupNameLabel.TabIndex = 2;
            groupNameLabel.Text = "Название группы";
            // 
            // groupPasswordLabel
            // 
            groupPasswordLabel.Anchor = AnchorStyles.Bottom;
            groupPasswordLabel.AutoSize = true;
            groupPasswordLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupPasswordLabel.Location = new Point(470, 350);
            groupPasswordLabel.Name = "groupPasswordLabel";
            groupPasswordLabel.Size = new Size(192, 35);
            groupPasswordLabel.TabIndex = 3;
            groupPasswordLabel.Text = "Пароль группы";
            // 
            // changeGroupNameButton
            // 
            changeGroupNameButton.Anchor = AnchorStyles.Bottom;
            changeGroupNameButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeGroupNameButton.Location = new Point(272, 354);
            changeGroupNameButton.MaximumSize = new Size(160, 80);
            changeGroupNameButton.MinimumSize = new Size(120, 80);
            changeGroupNameButton.Name = "changeGroupNameButton";
            changeGroupNameButton.Size = new Size(120, 80);
            changeGroupNameButton.TabIndex = 4;
            changeGroupNameButton.Text = "Изменить";
            changeGroupNameButton.UseVisualStyleBackColor = true;
            // 
            // displayUsersControl1
            // 
            displayUsersControl1.AutoScroll = true;
            displayUsersControl1.BorderStyle = BorderStyle.FixedSingle;
            displayUsersControl1.Location = new Point(16, 10);
            displayUsersControl1.MinimumSize = new Size(650, 300);
            displayUsersControl1.Name = "displayUsersControl1";
            displayUsersControl1.Size = new Size(650, 300);
            displayUsersControl1.TabIndex = 5;
            // 
            // ManageStudyGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(displayUsersControl1);
            Controls.Add(changeGroupNameButton);
            Controls.Add(groupPasswordLabel);
            Controls.Add(groupNameLabel);
            Controls.Add(nameBox);
            Controls.Add(passwordBox);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(700, 500);
            Name = "ManageStudyGroup";
            Text = "Manage study group - stests";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private Label groupPasswordLabel;
        private Label groupNameLabel;
        private TextBox nameBox;
        private TextBox passwordBox;
        private Button changeGroupNameButton;
        private DisplayUsersInGroupControl.DisplayUsersControl displayUsersControl1;
    }
}