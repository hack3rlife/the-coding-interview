using System;

namespace com.hack3rlife.datastructures
{
    public class StackNode<T>
    {
        /// <summary>
        /// Gets or Sets the value of the StackNode
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or Sets the next StackNode of the current StackNode
        /// </summary>
        public StackNode<T> Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public StackNode(T value, StackNode<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
