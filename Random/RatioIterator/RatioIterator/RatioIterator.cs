using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.random
{
    public class RatioIterator : IRatioIterator
    {
        /// <summary>
        /// Stores the values of the iterator
        /// </summary>
        private IList<int> _list;

        /// <summary>
        /// Keeps track of the current position of the iterator
        /// </summary>
        private int _current;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="numbers">Values to be stored in the iterator</param>
        public RatioIterator(IList<int> numbers)
        {
            _list = numbers;
            _current = 0;
        }

        /// <summary>
        /// Returns the next value in the iterator if it hasn't reach the end.
        /// </summary>
        /// <returns>The value at the current position of the iterator if it hasn't reach the end of the iterator; otherwise throws an IndexOutOfRangeException </returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public int getNext()
        {
            return _list[_current++];
        }

        /// <summary>
        /// Calculate the ratio of <para>value</para> based on the current position of the iterator
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The ratio of <para>value</para> at the current position of the iterator</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public double getRatio(int value)
        {
            var result = 0.0;


            var count = 0.0;

            for (int i = 0; i < _current; i++)
            {
                if (_list[i] == value)
                    count++;
            }

            result = count / _current;

            Debug.WriteLine("{0}. Ratio for {1} is {2}/{3}: {4}", _current, value, count, _current, result);

            return result;
        }

        /// <summary>
        /// Verify if the iterator has more elements
        /// </summary>
        /// <returns>true if iterator hasn't reach the last element; otherwise false</returns>
        public bool hasNext()
        {
            if (_current < _list.Count)
                return true;
            else
                return false;
        }
    }
}
