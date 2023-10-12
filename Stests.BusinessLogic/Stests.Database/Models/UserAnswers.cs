namespace Stests.BusinessLogic.Models
{
    using Stests.BusinessLogic.Models.JSON;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model of table containing user's answers for test in specific test session.
    /// </summary>
    public class UserAnswers
    {
        /// <summary>
        /// Id of the row.
        /// </summary>
        public Guid UserAnswersId { get; set; }

        /// <summary>
        /// Id of test which user has answered.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid TestId { get; set; }

        /// <summary>
        /// Id of user who gave answers to the test.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public Guid UserId { get; set; }

        /// <summary>
        /// Id of test session.
        /// </summary>
        [ForeignKey(nameof(TestSessions))]
        public Guid TestSessionId { get; set; }

        /// <summary>
        /// User answers contained as JSON-object.
        /// </summary>
        [Required]
        [Column(TypeName = "jsonb")]
        public Answers UserAnswer { get; set; }
    }
}