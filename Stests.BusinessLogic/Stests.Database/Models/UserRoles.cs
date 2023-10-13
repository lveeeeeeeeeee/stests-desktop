namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserRoles
    {
        [Key]
        public Guid role_id { get; set; }

        [Required]
        public required string role_name { get; set; }
    }
}