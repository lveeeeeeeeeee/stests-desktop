namespace Stests.BusinessLogic.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model of grades table in the database.
    /// </summary>
    public class Grades
    {
        /// <summary>
        /// Id of row with grade.
        /// </summary>
        [Key]
        public Guid grade_id { get; set; }

        /// <summary>
        /// Id of test which was solved.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid test_id { get; set; }

        /// <summary>
        /// Id of user who solved the test.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public Guid user_id { get; set; }

        /// <summary>
        /// Id of test session in which user solved the test.
        /// </summary>
        [ForeignKey(nameof(TestSessions))]
        public Guid test_session_id { get; set; }

        /// <summary>
        /// The grade that user recieved from the teacher by solving the test.
        /// </summary>
        [Required]
        public required int grade { get; set; }
    }
}