namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class that represents JSON-object of singular answer.
    /// </summary>
    public class Answer : IEquatable<Answer>
    {
        /// <summary>
        /// Id of the answered question in JSON-object corresponding to that question.
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Contents of the answer.
        /// </summary>
        public string AnswerContent { get; set; }

        /// <summary>
        /// Implementation of IEquatable<Answer> interface.
        /// </summary>
        /// <param name="other">Nullable answer object compared to the current instance of answer.</param>
        /// <returns>Whether the objects are equal (in boolean).</returns>
        public bool Equals(Answer? other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return other.AnswerContent == AnswerContent && other.QuestionId == QuestionId;
            }
        }

        /// <summary>
        /// Override of Equals() method.
        /// </summary>
        /// <param name="obj">Object compared with given instance of Answer object.</param>
        /// <returns>Whether the objects are equal.</returns>
        public override bool Equals(object? obj)
        {
            var answer = obj as Answer;
            return Equals(answer);
        }

        public override int GetHashCode()
        {
            return QuestionId.GetHashCode() + AnswerContent.GetHashCode();
        }
    }
}
