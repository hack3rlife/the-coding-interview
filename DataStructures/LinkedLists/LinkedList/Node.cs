namespace com.hack3rlife.datastructures
{
    public class LinkedListNode<T>
    {
        public T Value { get; private set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode()
        {
            this.Next = null;
        }

        public LinkedListNode(T value)
            : this()
        {
            this.Value = value;
        }

        public LinkedListNode(T value, LinkedListNode<T> next)
            : this(value)
        {
            this.Next = next;
        }
    }
}
