namespace Stests.DisplayTestsControl
{
    partial class DisplayTestsControl
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
            testsControlPanel = new Panel();
            SuspendLayout();
            // 
            // testsControlPanel
            // 
            testsControlPanel.AutoScroll = true;
            testsControlPanel.BackColor = SystemColors.ControlLight;
            testsControlPanel.BorderStyle = BorderStyle.FixedSingle;
            testsControlPanel.Dock = DockStyle.Fill;
            testsControlPanel.Location = new Point(0, 0);
            testsControlPanel.Name = "testsControlPanel";
            testsControlPanel.Size = new Size(720, 480);
            testsControlPanel.TabIndex = 0;
            // 
            // DisplayTestsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(testsControlPanel);
            Name = "DisplayTestsControl";
            Size = new Size(720, 480);
            ResumeLayout(false);
        }

        #endregion

        private Panel testsControlPanel;
    }
}