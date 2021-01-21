using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparkfishAssessment.Utility.Listifier
{
    public class Listify : IList<int>
    {
        private readonly IEnumerable<int> sequence;
        private readonly int start;
        private readonly int end;

        /// <summary>
        /// Listify Constructor
        /// </summary>
        /// <param name="start">First value in the range</param>
        /// <param name="end">Last value in the range</param>
        public Listify(int start, int end)
        {
            this.start = start;
            this.end = end;
            sequence = Enumerable.Range(start, end);
        }

        /// <summary>
        /// Element access operator
        /// </summary>
        /// <param name="index">Index of the value to retrieve</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                // index can't be greater than the number of values in the range
                if (index < 0 || index > (end - start))
                    throw new IndexOutOfRangeException();

                return sequence.Where((x, i) => i == index).Single();
            }
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Get the count of values in the collection
        /// </summary>
        public int Count => end - start;

        /// <summary>
        /// Get boolean representing read-only status
        /// </summary>
        public bool IsReadOnly => true;

        /// <summary>
        /// Add an item to the range.  This isn't supported because individual values in the collection aren't
        /// stored in memory.
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears the values from the collection.  This isn't supported because individual values in the collection aren't
        /// stored in memory.
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check to see if the collection of values contains a given item.
        /// </summary>
        /// <param name="item">Item to check for.</param>
        /// <returns>Boolean value indicating if the collection contains the value.</returns>
        public bool Contains(int item)
        {
            if (item >= start && item <= end)
                return true;

            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that iterates through the collection</returns>
        public IEnumerator<int> GetEnumerator()
        {
            return sequence.GetEnumerator();
        }

        /// <summary>
        /// Get the index of an item, if contained within the collection
        /// </summary>
        /// <param name="item">Item to find the index of.</param>
        /// <returns>Index of the item, if located.  Otherwise, -1</returns>
        public int IndexOf(int item)
        {
            if (item >= start && item <= end)
                return item - start;

            return -1;
        }

        /// <summary>
        /// Inserts an item into the collection at the specified index.  Not supported because the collection's
        /// values aren't stored in memory.
        /// </summary>
        /// <param name="index">Index to add the item at</param>
        /// <param name="item">Item to add</param>
        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an item from the collection.  Not supported.
        /// </summary>
        /// <param name="item">Item to remove</param>
        /// <returns>Success or failure to remove the item.</returns>
        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an item from the collection at the specified index.  Not supported.
        /// </summary>
        /// <param name="index">Index from which to remove the item.</param>
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that iterates through the collection</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return sequence.GetEnumerator();
        }
    }
}
