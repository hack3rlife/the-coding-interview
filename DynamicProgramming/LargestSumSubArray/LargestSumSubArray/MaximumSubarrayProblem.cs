/*
 * @autor: Some smart guy on internet
 * @date: 04/29/2015
 * @project: MaximumSubarrayProblem
 * 
 */

using System;
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
        /// <returns>The max subarray sum</returns>
        /// <see cref="http://www.geeksforgeeks.org/largest-sum-contiguous-subarray/"/>
        /// <seealso cref="https://rafal.io/posts/codility-max-slice-sum.html"/>
        public static int MaxSubArraySum(int[] input)
        {
            int curr_max = input[0];
            int max_so_far = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                curr_max = Math.Max(input[i], curr_max + input[i]);
                max_so_far = Math.Max(curr_max, max_so_far);
            }

            return max_so_far;
        }
    }
}
