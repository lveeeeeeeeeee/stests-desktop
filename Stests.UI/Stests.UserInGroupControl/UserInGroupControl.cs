namespace Stests.UserInGroupControl
{
    public partial class UserInGroupControl : UserControl
    {
        /// <summary>
        /// User info property.
        /// </summary>
        public string UserInfo
        {
            get
            {
                return userInfo;
            }
            set
            {
                userInfo = value;
                UserInfoChanged?.Invoke();
            }
        }

        /// <summary>
        /// Private user info variable manipulated by its property.
        /// </summary>
        private string userInfo = "";

        /// <summary>
        /// Custom delegate type for handling user info changes.
        /// </summary>
        private delegate void InfoChanged();

        /// <summary>
        /// Event which triggers when user info is changed.
        /// </summary>
        private event InfoChanged UserInfoChanged;

        /// <summary>
        /// Default control constructor.
        /// </summary>
        public UserInGroupControl()
        {
            InitializeComponent();
            UserInfoChanged += UserInfoChangedHandler;
        }

        /// <summary>
        /// Control constructor with custom user info.
        /// </summary>
        /// <param name="info">User info.</param>
        public UserInGroupControl(string info)
        {
            InitializeComponent();
            UserInfoChanged += UserInfoChangedHandler;
            UserInfo = info;
        }

        /// <summary>
        /// User info change handler.
        /// </summary>
        private void UserInfoChangedHandler()
        {
            userInfoLabel.Text = UserInfo;
        }
    }
}