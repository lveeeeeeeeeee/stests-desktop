namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Users' table model.
    /// </summary>
    public class Users
    {
        /// <summary>
        /// User's unique identifier.
        /// </summary>
        [Key]
        public Guid UserId { get; set; }
    }
}