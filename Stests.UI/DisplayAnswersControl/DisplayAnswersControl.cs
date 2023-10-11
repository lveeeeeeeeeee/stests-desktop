using Stests.BusinessLogic.Models.JSON;
using Stests.AnswerControl;

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
            int i = 0;
            foreach (AnswerVariant plug in objectsToDisplay)
            {
                objectsToDisplay[i] = new AnswerPlug($"пример как должно работать {i + 1}");
                i++;
            }
        }

        public DisplayAnswersControl()
        {
            InitializeComponent();
            GetObjectsToDisplay();
            Question q = new Question();
        }
    }
}