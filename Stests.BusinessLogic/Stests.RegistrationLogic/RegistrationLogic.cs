namespace Stests.RegistrationLogic
{
    using Stests.Database;
    using Stests.BusinessLogic.Models;
    using PasswordGenerator;
    using System.Security.Cryptography;
    using System.Text;
    using Stests.LoginLogic;

    /// <summary>
    /// Class that describes logic of registration in the system.
    /// </summary>
    public static class RegistrationLogic
    {
        /// <summary>
        /// Generate login info for the user (login and password).
        /// </summary>
        /// <returns>UsersInfo object with login and password hash properties populated.</returns>
        public static UsersInfo GenerateLoginInfo()
        {
            string password = GeneratePassword();
            string login = GenerateLogin();

            return new UsersInfo(login, password);
        }

        /// <summary>
        /// Generate password for the user.
        /// </summary>
        /// <returns>New password.</returns>
        public static string GeneratePassword()
        {
            // Generate new password.
            string password = new Password().Next();
            byte[] passwordByteArray = password.ToCharArray()
                .Select(x => (byte)x)
                .ToArray();
            // Encode the password with SHA-256 algorythm.
            using (SHA256 cypherSHA256 = SHA256.Create())
            {
                byte[] hashValue = cypherSHA256.ComputeHash(passwordByteArray);
                password = Encoding.Default.GetString(hashValue);
            }

            return password;
        }

        /// <summary>
        /// Generate unique login string for the user.
        /// </summary>
        /// <returns>Unique logic string.</returns>
        public static string GenerateLogin()
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                // 3 tries to create a unique login.
                for (int i = 0; i < 3; i++)
                {
                    // Generate new login.
                    string login = new Password(true, true, false, false, 10).Next();
                    bool duplicate = LoginLogic.CheckLogin(login, context);
                    if (!duplicate)
                    {
                        return login;
                    }
                }
            }

            // tries expired, can't produce unique login.
            throw new UniqueValueNotGeneratedException("Can't generate unique login"); 
        }

        /// <summary>
        /// Register user in the system.
        /// </summary>
        /// <param name="name">User's name.</param>
        /// <param name="surname">User's surname.</param>
        /// <param name="patronymic">User's patronymic (optional).</param>
        /// <returns>Registered user's info.</returns>
        public static UsersInfo Register(string name, string surname, string? patronymic = null)
        {
            UsersInfo userInfo = GenerateLoginInfo();
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                Users user = new Users();
                context.Users.Add(user);

                userInfo.Name = name;
                userInfo.Surname = surname;
                userInfo.Patronymic = patronymic;
                userInfo.UserId = user.UserId;

                context.UserInfo.Add(userInfo);
            }
            return userInfo;
        }
    }

    /// <summary>
    /// Custom exception class for unique value generation failure.
    /// </summary>
    public class UniqueValueNotGeneratedException : Exception
    {
        /// <summary>
        /// Exception constructor based on message.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public UniqueValueNotGeneratedException(string message) 
            :base(message) { }
    }
}
