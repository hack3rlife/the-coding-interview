﻿/*
 * @autor: Some smart guy on internet
 * @date: 04/29/2015
 * @project: SubArrayGivenSum
 * 
 */

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Given an unsorted array of non-negative integers, find a continous subarray which adds to a given number.
    /// </summary>
    /// <see cref="http://www.geeksforgeeks.org/find-subarray-with-given-sum/"/>
    /// <example>
    /// input: arr[] = {1, 4, 20, 3, 10, 5}, sum = 33
    /// output: Sum found between indexes 1 and 4</example>
    public static class SubArrayGivenSum
    {
        /// <summary>
        /// Search for a subarray which values sum the given sum
        /// </summary>
        /// <param name="input">The input parameter</param>
        /// <param name="sum">The given sum</param>
        /// <returns>An arrray with the max sum, start index and end index for the max sum. 
        /// a[0] = 1 (true) if there is a subarray for given sum; oherwise 0 (false)
        /// a[1] = begin
        /// a[2] = end
        /// </returns>
        public static int[] GetSubArrayForGivenSum(int[] input, int sum)
        {
            int current_sum = 0;

            int begin = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                current_sum += input[i];

                if (sum == current_sum)
                {
                    end = i;

                    System.Diagnostics.Debug.WriteLine("Sum found between index {0} - {1}", begin, end);
                    return new int[] { 1, begin, end };
                }

                if (current_sum > sum || current_sum < 0)
                {
                    current_sum = 0;
                    i = begin++;
                    end = i;
                }
            }

            return new int[] { 0, begin, end };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/find-the-largest-subarray-with-0-sum/"/>
        public static int[] GetSubArrayWithSumZero(int[] input)
        {
            int sum = 0;
            int current_sum = 0;

            int begin = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                current_sum += input[i];

                if (sum == current_sum)
                {
                    end = i;

                    System.Diagnostics.Debug.WriteLine("Sum found between index {0} - {1}", begin, end);
                    return new int[] { 1, begin, end };
                }

                if (i == input.Length-1)
                {
                    current_sum = 0;
                    i = begin++;
                    end = i;
                }
            }

            return new int[] { 0, begin, end };

        }
    }
}
