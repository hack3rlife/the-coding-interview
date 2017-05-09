using System;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    public class MinHeap<T> : HeapBaseClass<T> where T : IComparable<T>
    {
        public MinHeap() : base()
        {

        }

        public MinHeap(IList<T> list) : base()
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.Add(list[i]);
            }
        }

        public T Min => Items[0];

        public override T Extract()
        {
            T min = default(T);

            if (this.Items.Count > 0)
            {
                min = Items[0];

                Items[0] = Items[Items.Count - 1];

                Items.RemoveAt(Items.Count - 1);

                BuildHeap();
            }

            return min;
        }

        /// <summary>
        /// Min-Heapify
        /// </summary>
        /// <param name="currIndex"></param>
        /// <param name="heapsize"></param>
        public override void Heapify(int currIndex, int heapsize)
        {
            int leftChildIndex = 2 * currIndex + 1;
            int rightChildIndex = 2 * currIndex + 2;
            int smallest = currIndex;

            T parent = Items[currIndex];

            if (leftChildIndex < heapsize)
            {
                T left = Items[leftChildIndex];

                if (left.CompareTo(parent) < 0)
                    smallest = leftChildIndex;
            }

            if (rightChildIndex < heapsize)
            {
                T right = Items[rightChildIndex];

                if (right.CompareTo(parent) < 0)
                    smallest = rightChildIndex;
            }

            if (smallest != currIndex)
            {
                Swap(Items, currIndex, smallest);
                Heapify(smallest, currIndex);
            }
        }

        public override void Add(T t)
        {
            Items.Add(t);

            BuildHeap();
        }
    }
}
