namespace Stests.BusinessLogic.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Object model of correct answers in the database.
    /// </summary>
    internal class CorrectAnswers
    {
        /// <summary>
        /// ID of the row.
        /// </summary>
        [Key]
        public Guid CorrectAnswersId { get; set; }

        /// <summary>
        /// ID of specific test.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid TestId { get; set; }

        /// <summary>
        /// Correct answers for a specific test in JSON format.
        /// </summary>
        [Required]
        [Column(TypeName = "jsonb")]
        public required string CorrectAnswersJson { get; set; }
    }
}