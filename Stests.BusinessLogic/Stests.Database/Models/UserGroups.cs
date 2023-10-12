namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserGroups
    {
        [Key]
        public Guid GroupId { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}