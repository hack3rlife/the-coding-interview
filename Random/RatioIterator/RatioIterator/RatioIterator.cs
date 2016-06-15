using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.random
{
    public class RatioIterator : IRatioIterator
    {
        private IList<int> _list;

        private int _current;

        public RatioIterator(IList<int> numbers)
        {
            _list = numbers;
            _current = 0;
        }

        public int getNext()
        {
            if (hasNext())
            {
                return _list[_current++];
            }

            throw new IndexOutOfRangeException();
        }

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

        public bool hasNext()
        {
            if (_current < _list.Count)
                return true;
            else
                return false;
        }
    }
}
