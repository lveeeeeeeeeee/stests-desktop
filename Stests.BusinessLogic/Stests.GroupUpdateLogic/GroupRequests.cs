namespace Stests.GroupUpdateLogic
{
    using Stests.Database;
    using System.Linq;
    using Stests.BusinessLogic.Models;

    public static class GroupRequests
    {
        /// <summary>
        /// Create new user group.
        /// </summary>
        public static void CreateGroup()
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var userGroup = new UserGroups();
                context.user_groups.Add(userGroup);
            }
        }

        /// <summary>
        /// Create new user group based on name and password.
        /// </summary>
        /// <param name="name">User group name.</param>
        /// <param name="password">User group password.</param>
        public static void CreateGroup(string name, string password)
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var userGroup = new UserGroups(name, password);
                context.user_groups.Add(userGroup);
            }
        }

        /// <summary>
        /// Get information about users in group.
        /// </summary>
        /// <param name="group">Group info.</param>
        /// <returns>Enumerable of users info and group name.</returns>
        public static IEnumerable<UsersInGroup> GetUsersInGroup(UserGroups group)
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var usersInGroup = from users in context.user_info
                                   join group_user in context.user_group_relation on users.user_id equals group_user.user_id
                                   join groups in context.user_groups on group_user.group_id equals groups.group_id
                                   select new UsersInGroup(users.name, users.surname, users.patronymic, groups.name);
                //new
                //{
                //    Name = users.name,
                //    Surname = users.surname,
                //    Patronymic = users.patronymic,
                //    GroupName = groups.name
                //};
                var usersCollection = usersInGroup.ToArray<UsersInGroup>();
                return usersCollection;
            }
        }

        /// <summary>
        /// Get all groups user has joined.
        /// </summary>
        /// <returns>Enumerable of groups user has joined.</returns>
        public static IEnumerable<GroupsOfUsers> GetGroupsWithUser()
        {
            using (AppDbContext context = new DefaultDbContextFactory().CreateDbContext())
            {
                var usersInGroup = from groups in context.user_groups

                                   join group_user in context.user_group_relation on groups.group_id equals group_user.group_id
                                   join roles in context.roles on group_user.role_id equals roles.role_id
                                   join users in context.user_info on group_user.user_id equals users.user_id
                                   select new GroupsOfUsers(groups.name, roles.role_name);
                //new
                //{
                //    Name = groups.name,
                //    RoleName = group_user.role_id
                //};
                var usersCollection = usersInGroup.ToArray<GroupsOfUsers>();
                return usersCollection;
            }
        }
    }

    public class UsersInGroup
    {
        public UsersInGroup(string name, string surname, string patronymic, string groupName)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            GroupName = groupName;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string? Patronymic { get; set; }

        public string GroupName { get; set; }
    }

    public class GroupsOfUsers
    {
        public GroupsOfUsers(string groupName, string roleName)
        {
            GroupName = groupName;
            RoleName = roleName;
        }

        public string GroupName { get; set; }

        public string RoleName { get; set; }
    }
}
