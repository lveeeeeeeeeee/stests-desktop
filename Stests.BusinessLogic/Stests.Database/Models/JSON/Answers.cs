using System.Collections;

namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class that represents JSON-object of answers list.
    /// </summary>
    public class Answers : ICollection<Answer>
    {
        /// <summary>
        /// List of answers given.
        /// </summary>
        public Answer[] AnswersList { get; set; }

        ///<inheritdoc/>
        public int Count => throw new NotImplementedException();

        ///<inheritdoc/>
        public bool IsReadOnly => throw new NotImplementedException();

        ///<inheritdoc/>
        public void Add(Answer item)
        {
            Answer[] newAnswersList = new Answer[AnswersList.Length + 1];
            int i = 0;
            foreach (Answer elem in AnswersList)
            {
                newAnswersList[i++] = elem;
            }
            newAnswersList[i] = item;
            AnswersList = newAnswersList;
        }

        ///<inheritdoc/>
        public void Clear()
        {
            AnswersList = new Answer[0];
        }

        ///<inheritdoc/>
        public bool Contains(Answer item)
        {
            foreach (Answer answer in AnswersList)
            {
                if (item.Equals(answer))
                {
                    return true;
                }
            }
            return false;
        }

        ///<inheritdoc/>
        public void CopyTo(Answer[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = AnswersList[i];
            }
        }

        ///<inheritdoc/>
        public IEnumerator<Answer> GetEnumerator()
        {
            return (IEnumerator<Answer>)AnswersList.GetEnumerator();
        }

        ///<inheritdoc/>
        public bool Remove(Answer item)
        {
            List<Answer> newAnswersList = AnswersList.ToList();
            bool result = newAnswersList.Remove(item);
            AnswersList = newAnswersList.ToArray();
            return result;
        }

        ///<inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return AnswersList.GetEnumerator();
        }
    }
}
