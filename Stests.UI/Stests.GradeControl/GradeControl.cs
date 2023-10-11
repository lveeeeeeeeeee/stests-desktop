namespace Stests.GradeControl
{
    public partial class GradeControl : UserControl
    {
        /// <summary>
        /// Custom delegate type for event.
        /// </summary>
        private delegate void GradeInfoChanged();

        /// <summary>
        /// Event which triggers when the grade info is changed.
        /// </summary>
        private event GradeInfoChanged gradeInfoChangedEvent;

        /// <summary>
        /// Property of grade info.
        /// </summary>
        public GradeInfoPlug GradeInfo
        {
            get
            {
                return gradeInfo;
            }
            set
            {
                gradeInfo = value;
                gradeInfoChangedEvent?.Invoke();
            }
        }

        /// <summary>
        /// Private variable controlled by grade info property.
        /// </summary>
        private GradeInfoPlug gradeInfo = new GradeInfoPlug();

        /// <summary>
        /// Default control constructor.
        /// </summary>
        public GradeControl()
        {
            InitializeComponent();
            gradeInfoChangedEvent += GradeInfoChangeHandler;
        }

        /// <summary>
        /// Control constructor by grade info.
        /// <param name="gradeInfo">Information about the grade.</param>
        /// </summary>
        public GradeControl(GradeInfoPlug gradeInfo)
        {
            InitializeComponent();
            gradeInfoChangedEvent += GradeInfoChangeHandler;
            GradeInfo = gradeInfo;
        }

        /// <summary>
        /// Grade info change handler.
        /// </summary>
        private void GradeInfoChangeHandler()
        {
            gradeLabel.Text = gradeInfo.Grade.ToString();
            testSessionNameLabel.Text = gradeInfo.Name;
        }
    }

    public class GradeInfoPlug
    {
        public string Name { get; set; } = "somename";

        public int Grade { get; set; } = 0;

        public GradeInfoPlug()
        {

        }

        public GradeInfoPlug(string name)
        {
            Name = name;
        }

        public GradeInfoPlug(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}