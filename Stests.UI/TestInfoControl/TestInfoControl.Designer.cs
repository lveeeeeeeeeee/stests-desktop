namespace TestInfoControl
{
    partial class TestInfoControl
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
            testNameLabel = new Label();
            testStartDateLabel = new Label();
            testStartDateInfo = new Label();
            testEndDateLabel = new Label();
            testEndDateInfo = new Label();
            startTestButton = new Button();
            SuspendLayout();
            // 
            // testNameLabel
            // 
            testNameLabel.Dock = DockStyle.Fill;
            testNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            testNameLabel.Location = new Point(0, 0);
            testNameLabel.MaximumSize = new Size(250, 0);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new Size(250, 238);
            testNameLabel.TabIndex = 0;
            testNameLabel.Text = "sample text";
            testNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // testStartDateLabel
            // 
            testStartDateLabel.AutoSize = true;
            testStartDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            testStartDateLabel.Location = new Point(275, 25);
            testStartDateLabel.Name = "testStartDateLabel";
            testStartDateLabel.Size = new Size(211, 28);
            testStartDateLabel.TabIndex = 1;
            testStartDateLabel.Text = "Начало тестирования";
            // 
            // testStartDateInfo
            // 
            testStartDateInfo.AutoSize = true;
            testStartDateInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            testStartDateInfo.Location = new Point(275, 60);
            testStartDateInfo.Name = "testStartDateInfo";
            testStartDateInfo.Size = new Size(113, 28);
            testStartDateInfo.TabIndex = 2;
            testStartDateInfo.Text = "дата время";
            // 
            // testEndDateLabel
            // 
            testEndDateLabel.AutoSize = true;
            testEndDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            testEndDateLabel.Location = new Point(275, 150);
            testEndDateLabel.Name = "testEndDateLabel";
            testEndDateLabel.Size = new Size(201, 28);
            testEndDateLabel.TabIndex = 3;
            testEndDateLabel.Text = "Конец тестирования";
            // 
            // testEndDateInfo
            // 
            testEndDateInfo.AutoSize = true;
            testEndDateInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            testEndDateInfo.Location = new Point(275, 185);
            testEndDateInfo.Name = "testEndDateInfo";
            testEndDateInfo.Size = new Size(113, 28);
            testEndDateInfo.TabIndex = 4;
            testEndDateInfo.Text = "дата время";
            // 
            // startTestButton
            // 
            startTestButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startTestButton.Location = new Point(550, 25);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(120, 190);
            startTestButton.TabIndex = 5;
            startTestButton.Text = "Начать тест";
            startTestButton.UseVisualStyleBackColor = true;
            // 
            // TestInfoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(startTestButton);
            Controls.Add(testEndDateInfo);
            Controls.Add(testEndDateLabel);
            Controls.Add(testStartDateInfo);
            Controls.Add(testStartDateLabel);
            Controls.Add(testNameLabel);
            Name = "TestInfoControl";
            Size = new Size(698, 238);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label testNameLabel;
        private Label testStartDateLabel;
        private Label testStartDateInfo;
        private Label testEndDateLabel;
        private Label testEndDateInfo;
        private Button startTestButton;
    }
}