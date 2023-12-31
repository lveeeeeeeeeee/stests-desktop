﻿namespace Stests.LoginLogic
{
    using Stests.Database.Helpers;
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
                    .user_info
                    .Select(x => x)
                    .Where(x => x.login == login);

                if (!users.Any())
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
                .user_info
                .Select(x => x)
                .Where(x => x.login == login);

            if (!users.Any())
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
            // Check if login and encoded password pair is present in the database.
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var userInfo = context
                    .user_info
                    .Select(x => x)
                    .Where(x => x.login == login && x.password_hash == password);

                if (!userInfo.Any())
                {
                    return false;
                }
                return true;
            }
        }
    }
}
