namespace Stests.BusinessLogic.Data
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Users' table model.
    /// </summary>
    internal class Users
    {
        /// <summary>
        /// User's unique identifier.
        /// </summary>
        [Key]
        public Guid UserId { get; set; }
    }
}