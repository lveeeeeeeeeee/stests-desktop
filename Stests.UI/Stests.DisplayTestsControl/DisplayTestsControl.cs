using TestInfoControl;

namespace Stests.DisplayTestsControl
{
    public partial class DisplayTestsControl : UserControl
    {
        private static TestInfoControl.TestInfoPlug[] objectsToDisplay { get; set; } = new TestInfoControl.TestInfoPlug[0];

        /// <summary>
        /// Get objects to display in the control.
        /// </summary>
        private void GetObjectsToDisplay()
        {
            for (int i = 0; i < 0; i++)
            {
                objectsToDisplay[i] = new TestInfoControl.TestInfoPlug($"пример как должно работать {i}");
            }
        }

        public DisplayTestsControl()
        {
            InitializeComponent();
            GetObjectsToDisplay();
            int i = 0;
            foreach (TestInfoPlug testInfo in objectsToDisplay)
            {
                var control = new TestInfoControl.TestInfoControl(testInfo);
                testsControlPanel.Controls.Add(control);
                control.Location = new Point(0, i++ * control.Height);
            }
            if (objectsToDisplay.Length == 0)
            {
                var control = new Label();
                testsControlPanel.Controls.Add(control);
                control.Text = "Нет доступных тестов";
                control.Font = new Font("Segoi UI", 30);
                control.Location = new Point(0, 0);
                control.Dock = DockStyle.Fill;
                control.TextAlign = ContentAlignment.MiddleCenter;
                control.BringToFront();
            }
        }
    }
}