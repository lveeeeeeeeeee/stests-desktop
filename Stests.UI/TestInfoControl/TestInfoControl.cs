namespace TestInfoControl
{
    public partial class TestInfoControl : UserControl
    {
        /// <summary>
        /// Custom delegate type for handling test info changes.
        /// </summary>
        private delegate void TestInfoChanged();

        /// <summary>
        /// Event that is triggered when user info is changed.
        /// </summary>
        private event TestInfoChanged testInfoChanged;

        /// <summary>
        /// Test info property.
        /// </summary>
        public TestInfoPlug TestInfo
        {
            get
            {
                return testInfo;
            }
            set
            {
                testInfo = value;
                testInfoChanged?.Invoke();
            }
        }

        /// <summary>
        /// Private user info variable manipulated by its property.
        /// </summary>
        private TestInfoPlug testInfo;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TestInfoControl()
        {
            InitializeComponent();
            testInfoChanged += TestInfoChangedHandler;
            TestInfo = new TestInfoPlug();
        }

        public TestInfoControl(TestInfoPlug _testInfo)
        {
            InitializeComponent();
            testInfoChanged += TestInfoChangedHandler;
            TestInfo = _testInfo;
        }

        /// <summary>
        /// Handler for test info changes.
        /// </summary>
        private void TestInfoChangedHandler()
        {
            testStartDateInfo.Text = testInfo.DateTimeStart.ToLongDateString();
            testEndDateInfo.Text = testInfo.DateTimeEnd.ToLongDateString();
            testNameLabel.Text = testInfo.Name;
        }
    }

    public class TestInfoPlug
    {
        public string Name { get; set; } = "testName";

        public DateTime DateTimeStart { get; set; } = DateTime.Today;
        public DateTime DateTimeEnd { get; set; } = DateTime.Today.AddDays(3);

        public TestInfoPlug()
        {

        }

        public TestInfoPlug(string name)
        {
            Name = name;
        }

        public TestInfoPlug(string name, DateTime start, DateTime end)
        {
            Name = name;
            DateTimeStart = start;
            DateTimeEnd = end;
        }
    }
}