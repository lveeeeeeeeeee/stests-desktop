namespace Stests.DisplayGradesControl
{
    partial class DisplayGradesControl
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
            gradesDisplayPanel = new Panel();
            SuspendLayout();
            // 
            // gradesDisplayPanel
            // 
            gradesDisplayPanel.AutoScroll = true;
            gradesDisplayPanel.Dock = DockStyle.Fill;
            gradesDisplayPanel.Location = new Point(0, 0);
            gradesDisplayPanel.Name = "gradesDisplayPanel";
            gradesDisplayPanel.Size = new Size(780, 360);
            gradesDisplayPanel.TabIndex = 0;
            // 
            // DisplayGradesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(gradesDisplayPanel);
            Name = "DisplayGradesControl";
            Size = new Size(780, 360);
            ResumeLayout(false);
        }

        #endregion

        private Panel gradesDisplayPanel;
    }
}