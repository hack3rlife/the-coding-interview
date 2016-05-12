/*
 * @autor: Some smart guy on internet
 * @date: 06/01/2015
 * @project: QuickSelect
 * 
 */

namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    /// Quickselect is a divide-and-conquer algorithm to find the kth smallest element in an unordered list. 
    /// It is related to the quicksort sorting algorithm and  it is efficient in practice and has good average-case performance, but has poor worst-case performance.
    /// As with quicksort, quickselect is generally implemented as an in-place algorithm, and beyond selecting the k'th element, it also partially sorts the data. 
    /// </summary>
    /// <remarks>
    /// Worst case: О(n2)
    /// Average case: О(n)
    /// Best Case: O(n)
    /// Space Required: 
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Quickselect"/>
    public class QuickSelect
    {
        /// <summary>
        /// Quickselect uses the same overall approach as quicksort, choosing one element as a pivot and partitioning the data in two based on the pivot, accordingly as less than or greater than
        /// the pivot. However, instead of recursing into both sides, as in quicksort, quickselect only recurses into one side – the side with the element it is searching for. This reduces the 
        /// average complexity from O(n log n) to O(n).
        /// </summary>
        /// <param name="input">The unsorted array</param>
        /// <param name="left">The left sub-array (k-1)</param>
        /// <param name="right">The right sub-array(k+1)</param>
        /// <param name="k">The  kth value</param>
        /// <returns>Returns the n-th smallest element of the array within left..right inclusive</returns>
        public static int Select(int[] input, int left, int right, int k)
        {
            if (left == right)
                return input[left];

            var randomPivotIndex = new System.Random().Next(left, right);

            var privotIndex = Partition(input, left, right, randomPivotIndex);

            if (privotIndex == k)
                return input[k];
            else if (k < privotIndex)
                return Select(input, left, privotIndex - 1, k); //right = pivot - 1;
            else
                return Select(input, privotIndex + 1, right, k); //left = pivot + 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left">The left index</param>
        /// <param name="right">The right index</param>
        /// <param name="pivot">Random pivot between left and rigth</param>
        /// <returns></returns>
        private static int Partition(int[] input, int left, int right, int pivot)
        {
            var pivotValue = input[pivot];  // left + (right - left) / 2;
            
            //move pivot to the end
            Swap(input, pivot, right); 

            var storeIndex = left;

            for (int i = left; i < right-1; i++)
            {
                if (input[i] < pivotValue)
                    Swap(input, i, storeIndex++);
            }

            // Move pivot to its final place
            Swap(input, storeIndex, right); 

            return storeIndex;
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
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
