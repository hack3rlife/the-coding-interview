namespace LinkedList
{
    public class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; set; }

        public Node()
        {
            this.Next = null;
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }

        public Node(T value, Node<T> next)
            : this(value)
        {
            this.Next = next;
        }
    }
}
