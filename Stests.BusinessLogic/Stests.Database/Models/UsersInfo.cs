namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Users' info table model.
    /// </summary>
    public class UsersInfo
    {
        [SetsRequiredMembersAttribute]
        /// <summary>
        /// Default constructor of the object.
        /// </summary>
        public UsersInfo()
        {
            Name = "";
            Surname = "";
            Login = "";
            PasswordHash = "";
        }

        [SetsRequiredMembersAttribute]
        /// <summary>
        /// Constructor of the UsersInfo object based on login and password info.
        /// </summary>
        /// <param name="login">Login string.</param>
        /// <param name="password">Password hash string</param>
        public UsersInfo(string login, string password)
        {
            Login = login;
            PasswordHash = password;
        }

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