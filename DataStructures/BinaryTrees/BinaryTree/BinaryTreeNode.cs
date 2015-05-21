using System;

namespace com.hack3rlife.binarytree
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            this.Left = null;
            this.Right = null;
            Value = value;
        }

        public void DisplayNode()
        {
            if (this != null)
                Console.Write(" {0} ", this.Value);
        }
    }
}
