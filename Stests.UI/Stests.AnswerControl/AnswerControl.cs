using Stests.BusinessLogic.Models.JSON;

namespace Stests.AnswerControl
{
    public partial class AnswerControl : UserControl
    {
        private AnswerVariant answer = new AnswerVariant();

        private event Action AnswerChangedEvent;

        public AnswerVariant Answer { 
            get {
                return answer;
            }
            set {
                answer = value;
                AnswerChangedEvent?.Invoke();
            }
        }

        public AnswerControl()
        {
            InitializeComponent();
            AnswerChangedEvent += AnswerChangedHandler;
        }

        public AnswerControl(AnswerVariant answer)
        {
            InitializeComponent();
            AnswerChangedEvent += AnswerChangedHandler;
            this.answer = answer;
        }

        private void AnswerChangedHandler()
        {
            answerLabel.AutoSize = true;
            answerLabel.MaximumSize = new Size(this.Width, 0);
            answerLabel.Text = answer.AnswerContent;
            answerLabel.Location = new Point(0, 20);
            this.Height = answerLabel.Height + 40;
        }
    }
}