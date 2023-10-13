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
        [Key]
        public Guid user_answers_id { get; set; }

        /// <summary>
        /// Id of test which user has answered.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid test_id { get; set; }

        /// <summary>
        /// Id of user who gave answers to the test.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public Guid user_id { get; set; }

        /// <summary>
        /// Id of test session.
        /// </summary>
        [ForeignKey(nameof(TestSessions))]
        public Guid test_session_id { get; set; }

        /// <summary>
        /// User answers contained as JSON-object.
        /// </summary>
        [Required]
        [Column(TypeName = "jsonb")]
        public Answers user_answer { get; set; }
    }
}