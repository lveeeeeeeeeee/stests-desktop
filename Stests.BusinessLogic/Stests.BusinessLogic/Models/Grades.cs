namespace Stests.BusinessLogic.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Model of grades table in the database.
    /// </summary>
    internal class Grades
    {
        /// <summary>
        /// Id of row with grade.
        /// </summary>
        [Key]
        public Guid GradeId { get; set; }

        /// <summary>
        /// Id of test which was solved.
        /// </summary>
        [ForeignKey(nameof(Tests))]
        public Guid TestId { get; set; }

        /// <summary>
        /// Id of user who solved the test.
        /// </summary>
        [ForeignKey(nameof(Users))]
        public Guid UserId { get; set; }

        /// <summary>
        /// Id of test session in which user solved the test.
        /// </summary>
        [ForeignKey(nameof(TestSessions))]
        public Guid TestSessionId { get; set; }

        /// <summary>
        /// The grade that user recieved from the teacher by solving the test.
        /// </summary>
        [Required]
        public required int Grade { get; set; }
    }
}