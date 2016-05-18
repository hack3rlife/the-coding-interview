using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Follow-up: Implment a Stack using a Queue
    /// </summary>
    /// <typeparam name="int"></typeparam>
    public class StackQueue
    {
        private Queue _top;
        public int Count { get; private set; }

        public StackQueue()
        {
            _top = new Queue();
            Count = 0;
        }

        public void Push(int value)
        {
            _top.Enqueue(value);
            Count++;
        }

        public int Pop()
        {
            int value = -1;
            for (int i = 0; i < Count; i++)
            {
                value = (int)_top.Dequeue();
                _top.Enqueue(value);
            }
            Count--;
            return value;
        }

    }
}