namespace Stests.BusinessLogic.Models
{
    using Stests.BusinessLogic.Models.JSON;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Object model of tests in the database.  
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Id of the test in the database.
        /// </summary>
        [Key]
        public Guid test_id { get; set; }

        /// <summary>
        /// Name of the test.
        /// </summary>
        [Required]
        public required string test_name { get; set; }

        /// <summary>
        /// Short description of the test.
        /// </summary>
        [Required]
        public required string description { get; set; }

        /// <summary>
        /// Set of questions of the specific test in JSON format.
        /// </summary>
        [Required]
        [Column(TypeName = "jsonb")]
        public required Questions test_questions { get; set; }
    }
}