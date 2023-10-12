namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class that represents JSON-object of singular question.
    /// </summary>
    public class Question : IEquatable<Question>
    {
        /// <summary>
        /// Content of the question (the question itself).
        /// </summary>
        public string QuestionContent { get; set; }

        /// <summary>
        /// Type of question.
        /// </summary>
        public int QuestionType { get; set; }

        /// <summary>
        /// Id of the question in corresponding JSON-object.
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Collection of possible answers to the question.
        /// </summary>
        public AnswerVariants Variants { get; set; }

        /// <inheritdoc/>
        public bool Equals(Question? other)
        {
            if (other == null)
            {
                return false;
            }
            return other.QuestionContent == QuestionContent
                && other.QuestionId == QuestionId
                && other.QuestionType == QuestionType;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var question = obj as Question;
            return Equals(question);
        }
    }
}