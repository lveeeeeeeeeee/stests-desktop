﻿namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Object model of correct answers in the database.
    /// </summary>
    public class CorrectAnswers
    {
        /// <summary>
        /// ID of the row.
        /// </summary>
        [Key]
        public Guid сorrect_answers_id { get; set; }

        /// <summary>
        /// ID of specific test.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid test_id { get; set; }

        /// <summary>
        /// Correct answers for a specific test in JSON format.
        /// </summary>
        [Required]
        [Column(TypeName = "jsonb")]
        public required string correct_answers_json { get; set; }
    }
}