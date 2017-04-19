using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    public class LargestSubarrayWithZeroSum
    {
        /// <summary>
        /// Given an array of integers, find length of the largest subarray with sum equals to 0
        /// </summary>
        /// <param name="input"></param>
        /// <![CDATA[
        ///     Input: arr[] = {15, -2, 2, -8, 1, 7, 10, 23};
        ///     The largest subarray with 0 sum is -2, 2, -8, 1, 7
        ///     
        ///     Input: arr[] = {1, 2, 3}
        ///     Output: 0  (There is no subarray with 0 sum)
        ///
        ///     Input: arr[] = {1, 0, 3}
        ///     Output: 1
        /// ]]>
        /// <returns>
        /// An array where 
        /// arr[0] indicates if there is an array with sum = 0
        /// arr[1] indicates where the subarray begins
        /// arr[2] indicates where the subarray ends
        /// </returns>
        /// <see cref="http://www.geeksforgeeks.org/find-the-largest-subarray-with-0-sum/"/>
        public static int[] Get(int[] input)
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

                    Debug.WriteLine("Sum found between index {0} - {1}", begin, end);
                    return new int[] { 1, begin, end };
                }

                if (i == input.Length - 1)
                {
                    current_sum = 0;
                    i = begin++;
                    end = begin;
                }
            }

            return new int[] { 0, -1, -1 };

        }
    }
}
