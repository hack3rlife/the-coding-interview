using System.Diagnostics;

namespace com.hack3rlife.datastructures
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public void DisplayNode()
        {
            if (this != null)
                Debug.Write(string.Format(" {0} ", this.Value));
        }
    }
}
