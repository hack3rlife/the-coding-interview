using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.queue
{
    public class Node<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public Node(T value, Node<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
