namespace Stests.GroupLoginLogic
{
    using Stests.Database;
    using Stests.Database.Helpers;
    using System.Linq;

    public class GroupLoginLogic
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
                var groups = context
                    .user_groups
                    .Select(x => x)
                    .Where(x => x.Name == login);

                if (!groups.Any())
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
            var groups = dbContext
                .user_groups
                .Select(x => x)
                .Where(x => x.Name == login);

            if (!groups.Any())
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
            string passwordHash = PasswordHelper.ConvertPasswordToHash(password);

            // Check if login and encoded password pair is present in the database.
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var groupInfo = context
                    .user_groups
                    .Select(x => x)
                    .Where(x => x.Name == login && x.PasswordHash == passwordHash);

                if (!groupInfo.Any())
                {
                    return false;
                }
                return true;
            }
        }
    }
}
