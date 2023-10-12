namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserRoles
    {
        [Key]
        public Guid RoleId { get; set; }

        [Required]
        public required string RoleName { get; set; }
    }
}