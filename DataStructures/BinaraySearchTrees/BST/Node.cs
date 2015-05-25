using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures
{
    public class BinarySearchTreeNode<T> : IComparable<T> where T: IComparable<T>
    {

        public T Value { get; set; }

        public BinarySearchTreeNode<T> Left { get; set; }

        public BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode(T value)
        {
            Value = value;            
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        public  void DisplayNode()
        {
            if (this != null)
                Console.Write(" {0} ", this.Value);
        }        
    }
}
