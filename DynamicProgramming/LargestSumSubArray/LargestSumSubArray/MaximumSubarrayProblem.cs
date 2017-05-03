/*
 * @autor: Some smart guy on internet
 * @date: 04/29/2015
 * @project: MaximumSubarrayProblem
 * 
 */

using System.Diagnostics;

namespace com.hack3rlife.algorithms
{
    /// <summary>
    /// In computer science, the maximum subarray problem is the task of finding the contiguous subarray within a one-dimensional array of numbers which has the largest sum. For example, 
    /// for the sequence of values −2, 1, −3, 4, −1, 2, 1, −5, 4; the contiguous subarray with the largest sum is 4, −1, 2, 1, with sum 6.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Maximum_subarray_problem"/>
    public class MaximumSubarrayProblem
    {
        /// <summary>
        /// Kadane's algorithm consists of a scan through the array values, computing at each position the maximum (positive sum) subarray ending at that position. This subarray is either 
        /// empty (in which case its sum is zero) or consists of one more element than the maximum subarray ending at the previous position. The algorithm only needs to keep track of the 
        /// ending position because the implied starting position is just after the last position the sum went negative, and you can always get a higher sum by dropping any negative-sum 
        /// prefix.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>An arrray with the max sum, start index and end index for the max sum. 
        /// a[0] = max sum
        /// a[1] = start
        /// a[2] = end
        /// </returns>
        /// <see cref="http://www.geeksforgeeks.org/largest-sum-contiguous-subarray/"/>
        public static int[] GetLargestSum(int[] input)
        {
            int max_sum = 0;
            int current_sum = 0;

            int begin = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                current_sum += input[i];

                //if sum < 0, reset values
                if (current_sum < 0)
                {
                    current_sum = 0;
                    begin = i + 1;
                    end = begin;
                }

                if (max_sum < current_sum)
                {
                    max_sum = current_sum;
                    end = i;

                    Debug.WriteLine("Current Sum found between index {0} - {1}", begin, end);
                }
            }

            Debug.WriteLine("Max Sum: {0} found between index {1} - {2}", max_sum, begin, end);

            return new int[] { max_sum, begin, end };           
        }
    }
}
