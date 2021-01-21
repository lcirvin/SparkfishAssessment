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


        public Listify(int start, int end)
        {
            this.start = start;
            this.end = end;
            sequence = Enumerable.Range(start, end);
        }

        public int this[int index] { get
            {
                if (index > (end - start))
                    throw new IndexOutOfRangeException();

                return sequence.Where((x, i) => i == index).Single();
            } set => throw new NotImplementedException(); }

        public int Count => end - start;

        public bool IsReadOnly => true;

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

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

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            if (item >= start && item <= end)
                return item - start;

            return -1;
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
