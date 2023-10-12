namespace Stests.LoginLogic
{
    using Stests.BusinessLogic.Models;
    using Stests.Database;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public static class LoginLogic
    {
        /// <summary>
        /// Check if login exists in database.
        /// </summary>
        /// <param name="login">Login string.</param>
        /// <returns>Whether the login exists in the database.</returns>
        public static bool CheckLogin(string login)
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                // logins are unique
                var users = context
                    .UserInfo
                    .Select(x => x)
                    .Where(x => x.Login == login);

                if (users.Count() == 0)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Check if login exists in database.
        /// </summary>
        /// <param name="login">Login string.</param>
        /// <param name="dbContext">Database context created by extern using.</param>
        /// <returns>Whether the login exists in the database.</returns>
        public static bool CheckLogin(string login, AppDbContext dbContext)
        {
            // logins are unique
            var users = dbContext
                .UserInfo
                .Select(x => x)
                .Where(x => x.Login == login);

            if (users == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check if login and password pair is valid.
        /// </summary>
        /// <param name="login">Login string.</param>
        /// <param name="password">Password hash string.</param>
        /// <returns></returns>
        public static bool TryLogin(string login, string password)
        {
            // Convert password to byte array. 
            byte[] passwordByteArray = password.ToCharArray()
            .Select(x => (byte)x)
            .ToArray();
            // Encode the password with SHA-256 algorythm.
            string passwordHash = "";
            using (SHA256 cypherSHA256 = SHA256.Create())
            {
                byte[] hashValue = cypherSHA256.ComputeHash(passwordByteArray);
                passwordHash = Encoding.Default.GetString(hashValue);
            }

            // Check if login and encoded password pair is present in the database.
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var userInfo = context
                    .UserInfo
                    .Select(x => x)
                    .Where(x => x.Login == login && x.PasswordHash == passwordHash);

                if (userInfo == null)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
