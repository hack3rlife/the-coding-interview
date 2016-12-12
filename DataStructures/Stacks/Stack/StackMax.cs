using System;
using System.Collections;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Design a stack that supports push, pop, top, and retrieving the maximum element in constant time.
    /// </summary>
    /// <typeparam name="int"></typeparam>
    public class StackMax : IEnumerable
    {
        private int _max = int.MinValue;

        private StackNode _top;

        /// <summary>
        /// Gets the number of elements contained in the Stack.
        /// </summary>
        public int Count { get; private set; }

        public  void Push(int value)
        {
            if (value > _max)
            {
                _max = value;
                Push(_max);
            }

            StackNode node = new StackNode(value);

            if (Count >= 1)
            {
                node.Next = _top;
                _top = node;
            }
            else
            {
                _top = node;                
            }

            Count++;
        }

        public int Pop()
        {
            if (Count > 0)
            {
                int result = _top.Value;

                _top = _top.Next;

                Count--;

                if(result == _max)
                {
                    _top = _top.Next;

                    if (_top == null)
                        _max = int.MinValue;
                    else
                        _max = _top.Value;

                    Count--;
                }

                return result;
            }

            throw new NullReferenceException("The Stack is empty");
        }

        /// <summary>
        /// Returns the object at the top of the Stack without removing it.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            int result = default(int);

            if (Count > 0)
            {
                result = _top.Value;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetMax()
        {
            return _max;
        }

        /// <summary>
        /// Returns an enumerator for the Stack.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            // TODO: Update this definition to include _max value
            while (_top != null)
            {
                int result = _top.Value;
                _top = _top.Next;

                yield return result;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
