﻿namespace Stests.BusinessLogic.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model of the table of users' relations to groups.
    /// </summary>
    internal class UserGroupRelations
    {
        /// <summary>
        /// Primary key of the table.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// GroupId in which the user is registered.
        /// </summary>
        [ForeignKey(nameof(UserGroups))]
        public ICollection<Guid> GroupId { get; set; }

        /// <summary>
        /// User's id.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public ICollection<Guid> UserId { get; set; }

        /// <summary>
        /// Id of the role of this user in the given group.
        /// </summary>
        [ForeignKey(nameof(UserRoles))]
        public Guid RoleId { get; set; }
    }
}