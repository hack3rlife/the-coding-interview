namespace com.hack3rlife.datastructures
{
    public class StackNode
    {
        /// <summary>
        /// Gets or Sets the value of the StackNode
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or Sets the value of the StackNode
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// Gets or Sets the value of the StackNode
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// Gets or Sets the next StackNode of the current StackNode
        /// </summary>
        public StackNode Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="next"></param>
        public StackNode(int value, StackNode next = null, int min = int.MaxValue, int max = int.MinValue)
        {
            this.Value = value;
            this.Next = next;
            this.Min = min;
            this.Max = max;
        }
    }
}
