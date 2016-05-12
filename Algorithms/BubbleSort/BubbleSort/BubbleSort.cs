/*
 * @autor: Some smart guy on internet
 * @date: 04/28/2015
 * @project: BubbleSort
 * 
 */

namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    /// Bubble Sort is a simple sorting algorithm that repeatedly steps through the list to be sorted, compares each pair of adjacent items and swaps them if they are in the wrong order. 
    /// The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted. The algorithm, which is a comparison sort, is named for the way smaller 
    /// elements "bubble" to the top of the list. Although the algorithm is simple, it is too slow and impractical for most problems even when compared to insertion sort.
    /// </summary>
    /// <remarks>
    /// Worst case: О(n2)
    /// Average case: О(n2)
    /// Best Case: O(n)
    /// Space Required: O(n)
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Bubble_sort"/>
    public static class BubbleSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>        
        /// <param name="input">The unsorted array</param>        
        /// <returns>/>A sorted array</returns>
        /// <![CDATA[input: |8|4|1|6|2|0| output: |0|1|2|4|6|8|]]>
        public static int[] Sort(int[] input)
        {            
            //first loop to iterate through the full array
            for (int i = 0; i < input.Length; i++)
            {
                //second loop to check values from the current position of 'i' vs 'j'
                for (int j = i + 1; j < input.Length; j++)
                {
                    //check the lowest value and swap them: smaller in the left side; bigger in the right side
                    if (input[i] > input[j])
                    {
                        input[i] ^= input[j];
                        input[j] ^= input[i];
                        input[i] ^= input[j];
                    }
                }
            }

            return input;
        }
    }
}
