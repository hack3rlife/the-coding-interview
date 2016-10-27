using System;
using System.Diagnostics;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearchTreeNode<T> : IComparable<T> where T : IComparable<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BinarySearchTreeNode<T> Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BinarySearchTreeNode<T> Right { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public BinarySearchTreeNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DisplayNode()
        {
            if (this == null)
                return;

            Debug.Write(string.Format(" {0} ", this.Value));
        }
    }
}
