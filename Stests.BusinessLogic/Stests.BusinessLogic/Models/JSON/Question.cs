namespace Stests.BusinessLogic.Models.JSON
{
    using Stests.BusinessLogic.Models;

    /// <summary>
    /// Class that represents JSON-object of singular question.
    /// </summary>
    public class Question
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
        /// Constructor of question object.
        /// </summary>
        public Question()
        {
            QuestionContent = "";
            QuestionType = (int)QuestionTypes.SingularAnswer;
        }
    }
}