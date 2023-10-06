namespace Stests.BusinessLogic.Data
{
    using System.ComponentModel.DataAnnotations;

    internal class UserRoles
    {
        [Key]
        public Guid RoleId { get; set; }

        [Required]
        public required string RoleName { get; set; }
    }
}