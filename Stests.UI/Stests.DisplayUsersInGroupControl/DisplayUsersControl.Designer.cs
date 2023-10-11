namespace Stests.DisplayUsersInGroupControl
{
    partial class DisplayUsersControl
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
            userContainerPanel = new Panel();
            SuspendLayout();
            // 
            // userContainerPanel
            // 
            userContainerPanel.AutoScroll = true;
            userContainerPanel.Dock = DockStyle.Fill;
            userContainerPanel.Location = new Point(0, 0);
            userContainerPanel.Name = "userContainerPanel";
            userContainerPanel.Size = new Size(650, 300);
            userContainerPanel.TabIndex = 0;
            // 
            // DisplayUsersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(userContainerPanel);
            MinimumSize = new Size(650, 300);
            Name = "DisplayUsersControl";
            Size = new Size(650, 300);
            ResumeLayout(false);
        }

        #endregion

        private Panel userContainerPanel;
    }
}