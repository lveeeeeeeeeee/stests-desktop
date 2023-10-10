namespace Stests.DisplayUsersInGroupControl
{
    public partial class DisplayUsersControl : UserControl
    {
        private static Plug[] objectsToDisplay { get; set; } = new Plug[10];

        /// <summary>
        /// Get objects to display in the control.
        /// </summary>
        private void GetObjectsToDisplay()
        {
            for (int i = 0; i < 10; i++)
            {
                objectsToDisplay[i] = new Plug($"пример как должно работать {i}");
            }
        }

        /// <summary>
        /// Default control constructor.
        /// </summary>
        public DisplayUsersControl()
        {
            InitializeComponent();
            GetObjectsToDisplay();
            for (int i = 0; i < objectsToDisplay.Length; i++)
            {
                var control = new UserInGroupControl.UserInGroupControl(objectsToDisplay[i].lineToDisplay);
                userContainerPanel.Controls.Add(control);
                control.Location = new Point(0, i * 120);
            }
        }
    }

    public class Plug
    {
        public string lineToDisplay;

        public Plug()
        {
            lineToDisplay = "";
        }

        public Plug(string line)
        {
            lineToDisplay = line;
        }
    }
}