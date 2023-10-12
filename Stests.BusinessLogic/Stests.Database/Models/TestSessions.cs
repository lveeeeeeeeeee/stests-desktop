namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model of table with information about test sessions.
    /// </summary>
    public class TestSessions
    {
        /// <summary>
        /// Id of test session row in the table.
        /// </summary>
        [Key]
        public Guid TestSessionId { get; set; }

        /// <summary>
        /// Id of the solved test.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid TestId { get; set; }

        /// <summary>
        /// Id of student group for which test session was arranged.
        /// </summary>
        [ForeignKey(nameof(UserGroups))]
        public Guid GroupId { get; set; }

        /// <summary>
        /// Name of the test session.
        /// </summary>
        [Required]
        public string SessionName { get; set; }

        /// <summary>
        /// Date-time with timestamp of start of the test session.
        /// </summary>
        [Required]
        public DateTime SessionStart { get; set; }


        /// <summary>
        /// Date-time with timestamp of end of the test session.
        /// </summary>
        [Required]
        public DateTime SessionEnd { get; set; }
    }
}