namespace Stests.RegistrationLogic
{
    using Stests.BusinessLogic.Models;
    using PasswordGenerator;
    using System.Security.Cryptography;
    using System.Text;
    using Stests.Database;

    /// <summary>
    /// Class that describes logic of registration in the system.
    /// </summary>
    public class RegistrationLogic
    {
        /// <summary>
        /// Generate login info for the user (login and password).
        /// </summary>
        /// <returns>UsersInfo object with login and password hash properties populated.</returns>
        public UsersInfo GenerateLoginInfo()
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

            // Generate new login.
            string login = new Password(true, true, false, false, 10).Next();

            return new UsersInfo(login, password);
        }

        /// <summary>
        /// Register user in the system.
        /// </summary>
        /// <param name="name">User's name.</param>
        /// <param name="surname">User's surname.</param>
        /// <param name="patronymic">User's patronymic (optional).</param>
        public void Register(string name, string surname, string? patronymic)
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                Users user = new Users();
                context.Users.Add(user);

                UsersInfo userInfo = GenerateLoginInfo();
                userInfo.Name = name;
                userInfo.Surname = surname;
                userInfo.Patronymic = patronymic;
                userInfo.UserId = user.UserId;

                context.UserInfo.Add(userInfo);
            }
        }
    }
}
