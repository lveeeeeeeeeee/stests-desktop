namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Users' info table model.
    /// </summary>
    public class UsersInfo
    {
        /// <summary>
        /// ID of the entry.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// User's ID to which the info is related.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public Guid UserId { get; set; }

        /// <summary>
        /// User's name.
        /// </summary>
        [Required]
        public required string Name { get; set; }

        /// <summary>
        /// User's surname.
        /// </summary>
        [Required]
        public required string Surname { get; set; }

        /// <summary>
        /// User's patronymic.
        /// </summary>
        public string? Patronymic { get; set; }

        /// <summary>
        /// User's login handle in the system.
        /// </summary>
        [Required]
        public required string Login { get; set; }

        /// <summary>
        /// User's password hash code which we get from encrypting the password.
        /// </summary>
        [Required]
        public required string PasswordHash { get; set; }
    }
}