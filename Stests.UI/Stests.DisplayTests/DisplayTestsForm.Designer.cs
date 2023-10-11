namespace Stests.DisplayTests
{
    partial class DisplayTestsForm
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
            displayTestsControl1 = new DisplayTestsControl.DisplayTestsControl();
            SuspendLayout();
            // 
            // displayTestsControl1
            // 
            displayTestsControl1.Location = new Point(12, 40);
            displayTestsControl1.Name = "displayTestsControl1";
            displayTestsControl1.Size = new Size(720, 360);
            displayTestsControl1.TabIndex = 0;
            // 
            // DisplayTestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 453);
            Controls.Add(displayTestsControl1);
            Name = "DisplayTestsForm";
            Text = "Tests - stests";
            ResumeLayout(false);
        }

        #endregion

        private DisplayTestsControl.DisplayTestsControl displayTestsControl1;
    }
}