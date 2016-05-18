using System;
using System.Collections;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Represents a variable size last-in-first-out (LIFO) collection of instances of the same specified implemened by
    /// using LinkedList as underlaying datastructure.
    /// </summary>
    /// <typeparam name="int"></typeparam>
    public class StackMin : IEnumerable
    {
        private StackNode _top;

        /// <summary>
        /// Gets the number of elements contained in the Stack.
        /// </summary>
        public int Count { get; private set; }

        public StackMin()
        {
            _top = null;
            Count = 0;
        }

        /// <summary>
        /// Inserts an object at the top of the Stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
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

        /// <summary>
        /// Removes and returns the object at the top of the Stack.
        /// </summary>-
        /// <returns></returns>
        /// <exception cref="NullReferenceException"/>When stack is empty (Count = 0)</exception>
        public int Pop()
        {
            if (Count > 0)
            {
                int result = _top.Value;

                _top = _top.Next;

                Count--;

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
        /// Removes all objects from the Stack.
        /// </summary>
        public void Clear(){
            _top = null;
            Count = 0;
        }

        /// <summary>
        /// Returns an enumerator for the Stack.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
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
