namespace Stests.BusinessLogic.Data
{
    using System.ComponentModel.DataAnnotations;

    internal class UserGroups
    {
        [Key]
        public Guid GroupId { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}