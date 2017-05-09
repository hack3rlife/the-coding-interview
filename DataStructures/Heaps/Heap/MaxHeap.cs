using System;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    public class MaxHeap<T> : HeapBaseClass<T> where T : IComparable<T>
    {
        public MaxHeap() : base()
        {

        }

        public MaxHeap(IList<T> list) : base()
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.Add(list[i]);
            }

        }

        public T Max => Items[0];

        public override void Add(T t)
        {
            Items.Add(t);
            BuildHeap();
        }

        public override T Extract()
        {
            T max = default(T);

            if (this.Items.Count > 0)
            {
                max = Items[0];

                Items[0] = Items[Items.Count - 1];

                Items.RemoveAt(Items.Count - 1);

                BuildHeap();
            }

            return max;
        }

        /// <summary>
        /// Max-Heapify
        /// </summary>
        /// <param name="currIndex"></param>
        /// <param name="heapsize"></param>
        public override void Heapify(int currIndex, int heapsize)
        {
            int leftChildIndex = 2 * currIndex + 1;
            int rightChildIndex = 2 * currIndex + 2;
            int largest = currIndex;

            T parent = Items[currIndex];

            if (leftChildIndex < heapsize)
            {
                T left = Items[leftChildIndex];

                if (left.CompareTo(parent) > 0)
                    largest = leftChildIndex;
            }
            else
            {
                largest = currIndex;
            }


            if (rightChildIndex < heapsize)
            {
                T right = Items[rightChildIndex];

                if (right.CompareTo(Items[largest]) > 0)
                    largest = rightChildIndex;
            }

            if (largest != currIndex)
            {
                Swap(Items, currIndex, largest);
                Heapify(largest, heapsize);
            }
        }

    }
}
