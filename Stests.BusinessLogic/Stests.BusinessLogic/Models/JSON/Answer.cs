namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class that represents JSON-object of singular answer.
    /// </summary>
    internal class Answer
    {
        /// <summary>
        /// Id of the answered question in JSON-object corresponding to that question.
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Contents of the answer.
        /// </summary>
        public string AnswerContent { get; set; }
    }
}
