namespace com.hack3rlife.datastructures
{
    public class LinkedListNode
    {
        /// <summary>
        /// 
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public LinkedListNode Next { get; set; }

        public LinkedListNode()
        {
            this.Next = null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public LinkedListNode(int value, LinkedListNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }      
    }
}
