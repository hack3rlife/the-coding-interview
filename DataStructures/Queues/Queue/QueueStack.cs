using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.queue
{
    public class QueueStack<T> 
    {
        private Stack<T> input;
        private Stack<T> output;

        public int Count { get; set; }

        public QueueStack()
        {
            input = new Stack<T>();
            output = new Stack<T>();

            Count = 0;
        }

        public void Enqueue(T value)
        {
            input.Push(value);
            Count++;
        }

        public T Dequeue()
        {
            if (Count > 0)
            {
                T value = input.Pop();
                output.Push(value);
               

                for (int i = 0; input.Count>0; i++)
                {
                    value = input.Pop();
                    output.Push(value);
                 
                }

                for (int i = 0; output.Count>0; i++)
                {
                    input.Push(output.Pop());
                }

                Count--;
                return value;
            }

            throw new NullReferenceException("Queue is empty");
        }
    }
}
