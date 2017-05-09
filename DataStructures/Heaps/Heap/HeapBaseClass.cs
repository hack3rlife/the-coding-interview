using System;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class HeapBaseClass<T> where T : IComparable<T>
    {
        public IList<T> Items { get; private set; }

        public HeapBaseClass()
        {
            this.Items = new List<T>();
        }

        public abstract void Add(T t);

        public abstract T Extract();

        public abstract void Heapify(int start, int heapsize);

        public void BuildHeap()
        {
            int heapsize = Items.Count;

            //last parent node in the list
            int start = (heapsize - 1) / 2;

            while (start >= 0)
            {
                //sift down the node at start index such that all nodes below the start index are in heap order
                Heapify(start, heapsize);
                start--;
            }
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        /// <returns></returns>
        public void Swap(IList<T> input, int a, int b)
        {
            if (a != b)
            {
                var tmp = input[a];

                input[a] = input[b];
                input[b] = tmp;
            }
        }        
    }
}
