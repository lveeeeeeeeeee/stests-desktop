namespace DisplayAnswersControl
{
    partial class DisplayAnswersControl
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
            displayAnswersPanel = new Panel();
            SuspendLayout();
            // 
            // displayAnswersPanel
            // 
            displayAnswersPanel.Dock = DockStyle.Fill;
            displayAnswersPanel.Location = new Point(0, 0);
            displayAnswersPanel.Name = "displayAnswersPanel";
            displayAnswersPanel.Size = new Size(700, 450);
            displayAnswersPanel.TabIndex = 0;
            // 
            // DisplayAnswersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(displayAnswersPanel);
            Name = "DisplayAnswersControl";
            Size = new Size(700, 450);
            ResumeLayout(false);
        }

        #endregion

        private Panel displayAnswersPanel;
    }
}