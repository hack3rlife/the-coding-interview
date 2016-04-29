using System;
using System.Collections;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Represents a variable size last-in-first-out (LIFO) collection of instances of the same specified implemened by
    /// using LinkedList as underlaying datastructure.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IEnumerable<T>
    {
        private StackNode<T> _top;

        /// <summary>
        /// Gets the number of elements contained in the Stack<T>.
        /// </summary>
        public int Count { get; private set; }

        public Stack()
        {
            _top = null;
            Count = 0;
        }

        /// <summary>
        /// Inserts an object at the top of the Stack<T>.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            StackNode<T> node = new StackNode<T>(value);

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
        /// Removes and returns the object at the top of the Stack<T>.
        /// </summary>-
        /// <returns></returns>
        /// <exception cref="NullReferenceException"/>When stack is empty (Count = 0)</exception>
        public T Pop()
        {
            if (Count > 0)
            {
                T result = _top.Value;

                _top = _top.Next;

                Count--;

                return result;
            }

            throw new NullReferenceException("The Stack is empty");
        }

        /// <summary>
        /// Returns the object at the top of the Stack<T> without removing it.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            T result = default(T);

            if (Count > 0)
            {
                result = _top.Value;                
            }

            return result;
        }

        /// <summary>
        /// Removes all objects from the Stack<T>.
        /// </summary>
        public void Clear(){
            _top = null;
            Count = 0;
        }

        /// <summary>
        /// Returns an enumerator for the Stack<T>.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            while (_top != null)
            {
                T result = _top.Value;
                _top = _top.Next;

                yield return result;
            }
        }

       IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
