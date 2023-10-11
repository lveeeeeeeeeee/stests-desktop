namespace Stests.UserInGroupControl
{
    partial class UserInGroupControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userInfoLabel = new Label();
            deleteUserButton = new Button();
            SuspendLayout();
            // 
            // userInfoLabel
            // 
            userInfoLabel.Dock = DockStyle.Fill;
            userInfoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userInfoLabel.Location = new Point(0, 0);
            userInfoLabel.MaximumSize = new Size(450, 0);
            userInfoLabel.Name = "userInfoLabel";
            userInfoLabel.Size = new Size(450, 120);
            userInfoLabel.TabIndex = 0;
            userInfoLabel.Text = "sample text";
            userInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteUserButton.Location = new Point(480, 25);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(120, 70);
            deleteUserButton.TabIndex = 1;
            deleteUserButton.Text = "Удалить из группы";
            deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // UserInGroupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(deleteUserButton);
            Controls.Add(userInfoLabel);
            Name = "UserInGroupControl";
            Size = new Size(650, 120);
            ResumeLayout(false);
        }

        #endregion

        private Label userInfoLabel;
        private Button deleteUserButton;
    }
}