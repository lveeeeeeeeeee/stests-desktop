namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model of the table of users' relations to groups.
    /// </summary>
    public class UserGroupRelations
    {
        /// <summary>
        /// Primary key of the table.
        /// </summary>
        [Key]
        public Guid id { get; set; }

        /// <summary>
        /// GroupId in which the user is registered.
        /// </summary>
        [ForeignKey(nameof(UserGroups))]
        public Guid group_id { get; set; }

        /// <summary>
        /// User's id.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public Guid user_id { get; set; }

        /// <summary>
        /// Id of the role of this user in the given group.
        /// </summary>
        [ForeignKey(nameof(UserRoles))]
        public Guid role_id { get; set; }
    }
}