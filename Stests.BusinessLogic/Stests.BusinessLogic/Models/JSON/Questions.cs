using System.Collections;

namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class that represents JSON-object of set of questions.
    /// </summary>
    public class Questions : ICollection<Question>
    {
        /// <summary>
        /// List of questions.
        /// </summary>
        public Question[] QuestionList { get; set; }

        /// <inheritdoc/>
        public int Count => QuestionList.Count();

        /// <inheritdoc/>
        public bool IsReadOnly => QuestionList.IsReadOnly;

        /// <inheritdoc/>
        public void Add(Question item)
        {
            Question[] newQuestionsList = new Question[QuestionList.Length + 1];
            int i = 0;
            foreach (Question elem in QuestionList)
            {
                newQuestionsList[i++] = elem;
            }
            newQuestionsList[i] = item;
            QuestionList = newQuestionsList;
        }

        /// <inheritdoc/>
        public void Clear()
        {
            QuestionList = new Question[0];
        }

        /// <inheritdoc/>
        public bool Contains(Question item)
        {
            foreach (Question answer in QuestionList)
            {
                if (item.Equals(answer))
                {
                    return true;
                }
            }
            return false;
        }

        /// <inheritdoc/>
        public void CopyTo(Question[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = QuestionList[i];
            }
        }

        /// <inheritdoc/>
        public IEnumerator<Question> GetEnumerator()
        {
            return (IEnumerator<Question>)QuestionList.GetEnumerator();
        }

        /// <inheritdoc/>
        public bool Remove(Question item)
        {
            List<Question> newQuestionsList = QuestionList.ToList();
            bool result = newQuestionsList.Remove(item);
            QuestionList = newQuestionsList.ToArray();
            return result;
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return QuestionList.GetEnumerator();
        }
    }
}
