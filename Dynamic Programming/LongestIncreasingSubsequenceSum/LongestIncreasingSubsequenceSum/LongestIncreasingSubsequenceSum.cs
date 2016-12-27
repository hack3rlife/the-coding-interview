using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// Variaton of Longest increasing subsequence
    /// </summary>
    /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-14-maximum-sum-increasing-subsequence/"/>
    /// <seealso cref="https://www.youtube.com/watch?v=99ssGWhLPUE"/>
    public static class LongestIncreasingSubsequenceSum
    {
        /// <summary>
        /// Given an array of n positive integers. Write a program to find the sum of maximum sum subsequence of the given array such that the intgers in the subsequence are sorted in 
        /// increasing order
        /// </summary>
        /// <example>
        /// If input is {1, 101, 2, 3, 100, 4, 5}, then output should be 106 (1 + 2 + 3 + 100), if the input array is {3, 4, 5, 10}, then output should be 22 (3 + 4 + 5 + 10) and if the 
        /// input array is {10, 5, 4, 3}, then output should be 10
        /// </example>
        /// <param name="input">The input array</param>
        /// <returns>The Maximum Sum Increasing Subsequence</returns>
        public static int Get(int[] input)
        {
            int[] result = new int[input.Length];
            input.CopyTo(result, 0);

            int[] indexes = Initialize(new int[input.Length]);

            int i = 1;
            int j = 0;

            int sum = 0;
            int curr = 0;
            int max = 0;

            //edge case when first value is the highest in the array
            if (input[j] > input[i])
            {
                max = input[0];
                result[j] = max;
                i++;
            }

            while (i < input.Length)
            {
                j = 0;

                while (j < i)
                {
                    if (input[j] < input[i])
                    {
                        sum = input[i] + result[j];
                        curr = result[i];

                        if (sum > curr && sum > max)
                        {
                            max = sum;
                            result[i] = sum;
                            indexes[i] = j;

                            Print(result);
                            Print(indexes);
                        }
                    }

                    j++;
                }

                i++;
            }

            return max;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static int[] Initialize(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i;
            }

            return input;
        }

        private static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// Print the temporal DPT
        /// </summary>
        /// <param name="input">The table</param>
        private static void Print(int[] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                Debug.Write(string.Format("| {0} |", input[i]));
            }

            Debug.WriteLine("");
        }
    }
}
