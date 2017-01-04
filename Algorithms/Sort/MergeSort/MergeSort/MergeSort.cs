/*
 * @autor: Some smart guy on internet
 * @date: 04/28/2015
 * @project: MergeSort
 * 
 */

namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    /// In computer science, merge sort (also commonly spelled mergesort) is an efficient, general-purpose, comparison-based sorting algorithm. Most implementations produce a stable sort, 
    /// which means that the implementation preserves the input order of equal elements in the sorted output. Mergesort is a divide and conquer algorithm that was invented by 
    /// John von Neumann in 1945.
    /// Conceptually, a merge sort works as follows:
    /// * Divide the unsorted list into n sublists, each containing 1 element(a list of 1 element is considered sorted).
    /// * Repeatedly merge sublists to produce new sorted sublists until there is only 1 sublist remaining. This will be the sorted list.
    /// </summary>
    /// /// <remarks>
    /// Worst case: О(n log n)
    /// Average case: О(n log n)
    /// Best Case: О(n log n)
    /// Space Required: O(n)
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Merge_sort"/>
    public static partial class MergeSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>        
        /// <param name="input">Unordered array of <see cref="int"/></param>
        /// <returns>A sorted array of <see cref="int"/></returns>
        /// <![CDATA[input: |8|4|1|6|2|0| output: |0|1|2|4|6|8|]]>
        /// <remarks>Recursive Solution</remarks>
        public static int[] Sort(int[] input)
        {            
            if (input.Length == 1)
                return input;

            // Split the array in two 
            int mid = input.Length / 2;

            int[] left = new int[mid];
            for (int i = 0; i < left.Length; i++)
                left[i] = input[i];

            int[] right = new int[input.Length - mid];
            for (int i = 0; i < right.Length; i++)
                right[i] = input[mid++];

            // Recursive calls
            // 1. Recursive call to Sort(int[]) to break the array into smaller pieces
            // 2. After Sort(int[]) finish, we merge both arrays 
            return Merge(Sort(left), Sort(right));
        }

        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <see cref="http://www.geeksforgeeks.org/iterative-merge-sort/"/>
        /// <remarks>Iterative solution</remarks>
        public static void Sort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int m = left + (right - left) / 2;

                Sort(input, left, m);
                Sort(input, m + 1, right);
                Merge(input, left, m, right);
            }
        }        

        /// <summary>
        /// Merges two sorted arrays into a single sorted array
        /// </summary>
        /// <param name="left">Left sorted array</param>
        /// <param name="right">Right sorted array</param>
        /// <returns>A single sorted array of <see cref="int"/></returns>
        private static int[] Merge(int[] left, int[] right)
        {
            //Temporal array to store the result
            int[] merged = new int[left.Length + right.Length];

            int i = 0, j = 0, k = 0;

            while (k < merged.Length)
            {
                //if both arrays are in boundaries
                if (i < left.Length && j < right.Length)
                {
                    //check what value is the lowest and it's stored it in the current position of k  (sort the array in ascending order)    
                    //if you wish to sort in descending order, just change the operator from '<' to '>'          
                    if (left[i] < right[j])
                        merged[k++] = left[i++];
                    else
                        merged[k++] = right[j++];
                }
                else if (i < left.Length)     //if just left array
                    merged[k++] = left[i++];
                else if (j < right.Length)     //if just right array
                    merged[k++] = right[j++];
            }

            return merged;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <param name="r"></param>
        private static void Merge(int[] input, int l, int m, int r)
        {
            int i, j, k;

            int llength = m - l + 1;
            int rlength = r - m;

            int[] left = new int[llength];
            int[] right = new int[rlength];

            for (i = 0; i < left.Length; i++)
                left[i] = input[l + i];

            for (i = 0; i < right.Length; i++)
                right[i] = input[m + i + 1];

            i = 0;
            j = 0;
            k = l;

            while (i < llength && j < rlength)
            {
                if (left[i] <= right[j])
                    input[k++] = input[i++];
                else
                    input[k++] = input[j++];
            }

            while (i < llength)
                input[k++] = input[i++];

            while (j < rlength)
                input[k++] = input[j++];
        }
    }
}