namespace Stests.LoginLogic
{
    using Stests.Database;
    using System.Linq;

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

            if (users.Count() == 0)
            {
                return false;
            }
            return true;
        }
    }
}
