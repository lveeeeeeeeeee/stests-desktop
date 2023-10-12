namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class that describes the possible answer variant for a question in a test.
    /// </summary>
    public class AnswerVariant : IEquatable<AnswerVariant>
    {
        /// <summary>
        /// Id of the question.
        /// </summary>
        public string QuestionID { get; set; }

        /// <summary>
        /// Content of the answer variant.
        /// </summary>
        public string AnswerContent { get; set; }

        /// <inheritdoc/>
        public bool Equals(AnswerVariant? other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return other.QuestionID == QuestionID && other.AnswerContent == AnswerContent;
            }
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var answerVariant = obj as AnswerVariant;
            return Equals(answerVariant);
        }
    }
}
