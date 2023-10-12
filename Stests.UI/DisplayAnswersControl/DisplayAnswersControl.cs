using Stests.AnswerControl;
using Stests.BusinessLogic.Models.JSON;

namespace DisplayAnswersControl
{
    public partial class DisplayAnswersControl : UserControl
    {
        private AnswerVariants objectsToDisplay = new AnswerVariants();

        /// <summary>
        /// Get objects to display in the control.
        /// </summary>
        private void GetObjectsToDisplay()
        {

        }

        public DisplayAnswersControl()
        {
            InitializeComponent();
            GetObjectsToDisplay();
            int i = 0;
            foreach (AnswerVariant answer in objectsToDisplay)
            {
                var control = new AnswerControl();
                displayAnswersPanel.Controls.Add(control);
                control.Location = new Point(0, i++ * control.Height);
            }
            if (objectsToDisplay.Count() == 0)
            {
                var control = new Label();
                displayAnswersPanel.Controls.Add(control);
                control.Text = "Нет вариантов ответа 0_о как так";
                control.Font = new Font("Segoi UI", 30);
                control.Location = new Point(0, 0);
                control.Dock = DockStyle.Fill;
                control.TextAlign = ContentAlignment.MiddleCenter;
                control.BringToFront();
            }
        }
    }
}