namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;

    public class UserGroups
    {
        /// <summary>
        /// Default constructor for user group.
        /// </summary>
        [SetsRequiredMembersAttribute]
        public UserGroups()
        {
            name = "";
            password_hash = "";
        }

        /// <summary>
        /// Constructor for user group based on name and password.
        /// </summary>
        [SetsRequiredMembersAttribute]
        public UserGroups(string _name, string _password)
        {
            name = _name;
            password_hash = _password;
        }

        /// <summary>
        /// User group id.
        /// </summary>
        [Key]
        public Guid group_id { get; set; }

        /// <summary>
        /// User group name.
        /// </summary>
        [Required]
        public required string name { get; set; }

        /// <summary>
        /// User group password.
        /// </summary>
        [Required]
        public required string password_hash { get; set; }
    }
}