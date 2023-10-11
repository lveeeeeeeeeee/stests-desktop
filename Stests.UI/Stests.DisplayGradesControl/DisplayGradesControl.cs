using Stests.GradeControl;

namespace Stests.DisplayGradesControl
{
    public partial class DisplayGradesControl : UserControl
    {
        private static GradeControl.GradeInfoPlug[] objectsToDisplay { get; set; } = new GradeControl.GradeInfoPlug[5];

        /// <summary>
        /// Get objects to display in the control.
        /// </summary>
        private void GetObjectsToDisplay()
        {
            int i = 0;
            foreach (GradeInfoPlug plug in objectsToDisplay)
            {
                objectsToDisplay[i] = new GradeControl.GradeInfoPlug($"пример как должно работать {i+1}", new Random(DateTime.Now.Microsecond).Next(1, 10));
                i++;
            }
        }


        public DisplayGradesControl()
        {
            InitializeComponent();
            GetObjectsToDisplay();
            int i = 0;
            foreach (GradeInfoPlug gradeInfo in objectsToDisplay)
            {
                var control = new GradeControl.GradeControl(gradeInfo);
                gradesDisplayPanel.Controls.Add(control);
                control.Location = new Point(0, i++ * control.Height);
            }
            if (objectsToDisplay.Length == 0)
            {
                var control = new Label();
                gradesDisplayPanel.Controls.Add(control);
                control.Text = "Нет выставленных оценок";
                control.Font = new Font("Segoi UI", 30);
                control.Location = new Point(0, 0);
                control.Dock = DockStyle.Fill;
                control.TextAlign = ContentAlignment.MiddleCenter;
                control.BringToFront();
            }
        }
    }
}