namespace Stests.GroupUpdateLogic
{
    using Stests.Database.Helpers;
    using Stests.Database;
    using System.Linq;
    using Stests.BusinessLogic.Models;

    public class GroupRequests
    {
        public void GetGroupsForUser(UsersInfo userInfo)
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
            }
        }
    }
}
