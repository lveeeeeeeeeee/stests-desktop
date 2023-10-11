namespace Stests.DisplayGradesForm
{
    partial class DisplayGradesForm
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
            displayGradesControl1 = new DisplayGradesControl.DisplayGradesControl();
            SuspendLayout();
            // 
            // displayGradesControl1
            // 
            displayGradesControl1.BackColor = SystemColors.ControlLight;
            displayGradesControl1.BorderStyle = BorderStyle.FixedSingle;
            displayGradesControl1.Location = new Point(8, 40);
            displayGradesControl1.Name = "displayGradesControl1";
            displayGradesControl1.Size = new Size(780, 360);
            displayGradesControl1.TabIndex = 0;
            // 
            // DisplayGradesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displayGradesControl1);
            Name = "DisplayGradesForm";
            Text = "Grades - stests";
            ResumeLayout(false);
        }

        #endregion

        private DisplayGradesControl.DisplayGradesControl displayGradesControl1;
    }
}