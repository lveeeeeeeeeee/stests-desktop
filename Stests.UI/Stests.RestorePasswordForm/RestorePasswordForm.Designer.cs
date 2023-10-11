namespace Stests.RestorePasswordForm
{
    partial class RestorePasswordForm
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
            secretLabel = new Label();
            secretBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            secretButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // secretLabel
            // 
            secretLabel.AutoSize = true;
            secretLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            secretLabel.Location = new Point(20, 20);
            secretLabel.MaximumSize = new Size(300, 0);
            secretLabel.Name = "secretLabel";
            secretLabel.Size = new Size(290, 70);
            secretLabel.TabIndex = 0;
            secretLabel.Text = "Введите код восстановления пароля";
            // 
            // secretBox
            // 
            secretBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secretBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secretBox.Location = new Point(20, 110);
            secretBox.Name = "secretBox";
            secretBox.Size = new Size(290, 34);
            secretBox.TabIndex = 1;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // secretButton
            // 
            secretButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secretButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secretButton.Location = new Point(20, 160);
            secretButton.Name = "secretButton";
            secretButton.Size = new Size(290, 40);
            secretButton.TabIndex = 2;
            secretButton.Text = "Восстановить пароль";
            secretButton.UseVisualStyleBackColor = true;
            // 
            // RestorePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 223);
            Controls.Add(secretButton);
            Controls.Add(secretBox);
            Controls.Add(secretLabel);
            MaximumSize = new Size(350, 300);
            MinimumSize = new Size(350, 270);
            Name = "RestorePasswordForm";
            Text = "Restore password - stests";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label secretLabel;
        private TextBox secretBox;
        private ErrorProvider errorProvider;
        private Button secretButton;
    }
}