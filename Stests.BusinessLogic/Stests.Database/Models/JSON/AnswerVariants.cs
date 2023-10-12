using System.Collections;

namespace Stests.BusinessLogic.Models.JSON
{
    /// <summary>
    /// Class of collection of answer variants (for JSON bindings).
    /// </summary>
    public class AnswerVariants : ICollection<AnswerVariant>, IEquatable<AnswerVariants>
    {
        /// <summary>
        /// Collection of answer variants.
        /// </summary>
        public AnswerVariant[] Variants { get; set; }

        /// <inheritdoc/>
        public int Count => Variants.Count();

        /// <inheritdoc/>
        public bool IsReadOnly => Variants.IsReadOnly;

        /// <inheritdoc/>
        public void Add(AnswerVariant item)
        {
            AnswerVariant[] newAnswerVariants = new AnswerVariant[Variants.Length + 1];
            int i = 0;
            foreach (var variant in Variants)
            {
                newAnswerVariants[i++] = variant;
            }
            newAnswerVariants[i] = item;
            Variants = newAnswerVariants;
        }

        /// <inheritdoc/>
        public void Clear()
        {
            Variants = new AnswerVariant[0];
        }

        /// <inheritdoc/>
        public bool Contains(AnswerVariant item)
        {
            foreach (AnswerVariant answer in Variants)
            {
                if (item.Equals(answer))
                {
                    return true;
                }
            }
            return false;
        }

        /// <inheritdoc/>
        public void CopyTo(AnswerVariant[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = Variants[i];
            }
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            var answerVariants = obj as AnswerVariants;
            return Equals(answerVariants);
        }

        /// <inheritdoc/>
        public bool Equals(AnswerVariants? other)
        {
            if (other == null)
            {
                return false;
            }
            if (other.Variants.Length != Variants.Length)
            {
                return false;
            }
            for (int i = 0; i < Variants.Length; i++)
            {
                if (!Variants[i].Equals(other.Variants[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc/>
        public IEnumerator<AnswerVariant> GetEnumerator()
        {
            return (IEnumerator<AnswerVariant>)Variants.GetEnumerator();
        }

        /// <inheritdoc/>
        public bool Remove(AnswerVariant item)
        {
            List<AnswerVariant> newAnswersList = Variants.ToList();
            bool result = newAnswersList.Remove(item);
            Variants = newAnswersList.ToArray();
            return result;
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Variants.GetEnumerator();
        }
    }
}
