namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    ///  Heapsort is a comparison-based sorting algorithm.  Heapsort can be thought of as an improved selection sort: like that algorithm, 
    ///  it divides its input into a sorted and an unsorted region, and it iteratively shrinks the unsorted region by extracting the largest 
    ///  element and moving that to the sorted region.  The improvement consists of the use of a heap data structure rather than a linear-time 
    ///  search to find the maximum.
    ///  Heapsort is an in-place algorithm, but it is not a stable sort.
    /// </summary>
    /// <remarks>
    /// Worst case: О(n log n)
    /// Average case: О(n log n)
    /// Best Case: О(n log n)
    /// Space Required: O(1)
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Heapsort"/>
    public static class HeapSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>
        /// <param name="input">The unsorted array</param>
        /// <returns>A sorted array of integers</returns>
        public static int[] Sort(int[] input)
        {
            //Build the heap into an array so such a way the largest value is at root.
            Heapify(input);


            int end = input.Length - 1;
            while (end >= 0)
            {
                //swap the largest value which in this case will be always at position '0'
                Swap(input, end, 0);
                //reduce heapsize since we already 'remove' the largest value from the heap
                end--;
                //swap screw the heap, so we need to restore it
                SiftDown(input, 0, end);
            }
            return input;
        }

        /// <summary>
        /// Builds a heap from a list in O(n) operations.
        /// </summary>
        /// <remarks>Put the elements of <para>input</para> in heap order, in-place</remarks>
        /// <param name="input">The unsorted array</param>
        private static void Heapify(int[] input)
        {
            int heapsize = input.Length - 1;

            //last parent node in the list
            int start = (heapsize - 1) / 2;
            
            while (start >= 0)
            {
                //sift down the node at start index such that all nodes below the start index are in heap order
                SiftDown(input, start, heapsize);
                start--;
            }
        }

        private static void SiftDown(int[] input, int start, int end)
        {
            int root = start;

            while ((2 * root + 1)<= end)
            {
                int child = 2 * root + 1;
                int swap = root;

                //if root is less than its left child
                if(input[swap] < input[child])
                {
                    swap = child;
                }

                //if there is right child and is greater than
                if(child+1 <= end && input[swap] < input[child + 1])
                {
                    swap = child + 1;
                }

                if (swap == root)
                {
                    return;
                }
                else
                {
                    Swap(input, root, swap);

                    //we need to verify if more siftdown is needed at the current index
                    root = swap;
                }            
            }
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        /// <returns></returns>
        private static void Swap(int[] input, int a, int b)
        {
            if (a != b)
            {
                input[a] ^= input[b];
                input[b] ^= input[a];
                input[a] ^= input[b];
            }
        }

        
    }
}
