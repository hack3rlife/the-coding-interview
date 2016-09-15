/*
 * @autor: Some smart guy on internet
 * @date: 04/14/2016
 * @project: SelectionSort
 * 
 */

namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    /// Selection Sort is a sorting algorithm, specifically an in-place comparison sort. Is noted for its simplicity, and it has performance advantages over more complicated 
    /// algorithms in certain situations, particularly where auxiliary memory is limited.
    /// The algorithm divides the input list into two parts: the sublist of items already sorted, which is built up from left to right at the front (left) of the list, and the sublist of items 
    /// remaining to be sorted that occupy the rest of the list.  Initially, the sorted sublist is empty and the unsorted sublist is the entire input list. 
    /// </summary>
    /// <remarks>
    /// Worst case: О(n2)
    /// Average case: О(n2)
    /// Best Case: O(n)
    /// Space Required: O(n)
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Selection_sort"/>
    public static class SelectionSort
    {
        /// <summary>
        ///  The algorithm proceeds by finding the smallest (or largest, depending on sorting order) element in the unsorted sublist, exchanging (swapping) it with the leftmost unsorted
        ///  element (putting it in sorted order), and moving the sublist boundaries one element to the right.
        /// </summary>
        /// <param name="input">The unsorted array</param>
        /// <returns>A sorted array</returns>
        public static int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int smallest = i;
                for (int j = i+1; j < input.Length; j++)
                {
                    if(input[smallest] > input[j])
                        smallest = j;
                }

                Swap(input, smallest, i);
            }

            return input;
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
