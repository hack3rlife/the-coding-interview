using System;
using System.Collections;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Represents a variable size last-in-first-out (LIFO) collection of instances of the same specified implemened by
    /// using LinkedList as underlaying datastructure.
    /// </summary>
    /// <typeparam name="int"></typeparam>
    public class StackMax : Stack
    {
        private StackNode _max;

        public StackNode Max
        {
            get
            {
                return _max;
            }

            private set
            {
                _max = value;
            }
        }

        public StackMax() : base()
        {
            _max = null;
        }

        public override void Push(int value)
        {
            base.Push(value);
            UpdateMaxOnPush();
        }

        public override int Pop()
        {
            var value = base.Pop();
            UpdateMaxOnPop(value);

            return value;
        }

        private void UpdateMaxOnPush()
        {
            int peek = this.Peek();
            var curr = new StackNode(peek);

            if (_max == null)
            {
                _max = curr;
            }
            else
            {
                if (_max.Value < peek)
                {
                    curr.Next = _max;
                    Max = curr;
                }
                else
                {
                    var node = new StackNode(_max.Value);
                    node.Next = _max;
                    _max = node;
                }
            }
        }

        private void UpdateMaxOnPop(int value)
        {
            if (_max != null)
            {
                _max = _max.Next;
            }
        }
    }
}
