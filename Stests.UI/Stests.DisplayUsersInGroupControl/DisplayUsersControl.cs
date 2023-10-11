namespace Stests.DisplayUsersInGroupControl
{
    public partial class DisplayUsersControl : UserControl
    {
        private static Plug[] objectsToDisplay { get; set; } = new Plug[5];

        /// <summary>
        /// Get objects to display in the control.
        /// </summary>
        private void GetObjectsToDisplay()
        {
            int i = 0;
            foreach (Plug plug in objectsToDisplay)
            {
                objectsToDisplay[i] = new Plug($"пример как должно работать {i}");
                i++;
            }
        }

        /// <summary>
        /// Default control constructor.
        /// </summary>
        public DisplayUsersControl()
        {
            InitializeComponent();
            GetObjectsToDisplay();
            int i = 0;
            foreach (Plug plug in objectsToDisplay)
            {
                var control = new UserInGroupControl.UserInGroupControl(plug.lineToDisplay);
                userContainerPanel.Controls.Add(control);
                control.Location = new Point(0, i++ * control.Height);
            }
            if (objectsToDisplay.Length == 0)
            {
                var control = new Label();
                userContainerPanel.Controls.Add(control);
                control.Text = "В данной группе ещё никто не состоит";
                control.Font = new Font("Segoi UI", 30);
                control.Location = new Point(0, 0);
                control.Dock = DockStyle.Fill;
                control.TextAlign = ContentAlignment.MiddleCenter;
                control.BringToFront();
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