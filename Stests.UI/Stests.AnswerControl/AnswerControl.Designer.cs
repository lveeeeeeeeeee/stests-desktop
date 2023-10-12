namespace Stests.AnswerControl
{
    partial class AnswerControl
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
            answerLabel = new Label();
            SuspendLayout();
            // 
            // answerLabel
            // 
            answerLabel.Dock = DockStyle.Fill;
            answerLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            answerLabel.Location = new Point(0, 0);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(700, 200);
            answerLabel.TabIndex = 0;
            answerLabel.Text = "sample text";
            answerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(answerLabel);
            Name = "AnswerControl";
            Size = new Size(700, 200);
            ResumeLayout(false);
        }

        #endregion

        private Label answerLabel;
    }
}