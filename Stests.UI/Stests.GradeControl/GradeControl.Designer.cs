namespace Stests.GradeControl
{
    partial class GradeControl
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
            testSessionNameLabel = new Label();
            gradeLabel = new Label();
            SuspendLayout();
            // 
            // testSessionNameLabel
            // 
            testSessionNameLabel.Dock = DockStyle.Left;
            testSessionNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            testSessionNameLabel.Location = new Point(0, 0);
            testSessionNameLabel.MaximumSize = new Size(500, 0);
            testSessionNameLabel.Name = "testSessionNameLabel";
            testSessionNameLabel.Size = new Size(500, 198);
            testSessionNameLabel.TabIndex = 0;
            testSessionNameLabel.Text = "sample text";
            testSessionNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradeLabel
            // 
            gradeLabel.Dock = DockStyle.Right;
            gradeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gradeLabel.Location = new Point(498, 0);
            gradeLabel.MaximumSize = new Size(280, 0);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(280, 198);
            gradeLabel.TabIndex = 1;
            gradeLabel.Text = "sampleText";
            gradeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GradeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(gradeLabel);
            Controls.Add(testSessionNameLabel);
            Name = "GradeControl";
            Size = new Size(778, 198);
            ResumeLayout(false);
        }

        #endregion

        private Label testSessionNameLabel;
        private Label gradeLabel;
    }
}