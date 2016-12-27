/*
 * @autor: Some smart guy on internet
 * @date: 05/05/2015
 * @project: SubSetSum
 * 
 */
using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// In computer science, the subset sum problem is an important problem in complexity theory and cryptography. The problem is this: given a set (or multiset) of integers, is there a 
    /// non-empty subset whose sum is zero?.
    /// Given the set {−7, −3, −2, 5, 8}, the answer is yes because the subset {−3, −2, 5} sums to zero.
    /// An equivalent problem is this: given a set of integers and an integer s, does any non-empty subset sum to s? Subset sum can also be thought of as a special case of the knapsack 
    /// problem.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Subset_sum_problem"/>
    /// <!--Given a set of non-negative integers, and a value sum, determine if there is a subset of the given set with sum equal to given sum.-->
    /// <![CDATA[
    ///             input: set[] = {3, 34, 4, 12, 5, 2}, sum = 9
    ///             output: True  //There is a subset (4, 5) with sum 9.
    /// ]]>
    public static class SubSetSum
    {
        /// <summary>
        /// A recursive solution for subset sum problem
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <param name="n"></param>
        /// <param name="sum"></param>
        /// <returns>True if there is a subset; otherwise false</returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-subset-sum-problem/"/>
        public static bool IsSubSetSum(int[] input, int n, int sum)
        {
            if (sum == 0)
                return true;
            if (n == 0 && sum != 0)
                return false;

            // if last element is greater than sum, then ignore it
            if (input[n - 1] > sum)
                return IsSubSetSum(input, n - 1, sum);

            /* else, check if sum can be obtained by any of the following
                (a) including the last element
                (b) excluding the last element   */
            return IsSubSetSum(input, n - 1, sum) || IsSubSetSum(input, n - 1, sum - input[n - 1]);
        }

        /// <summary>
        /// Dynamic solution for subset sum problem
        /// </summary>
        /// <param name="input">The input array</param>
        /// <param name="sum">The sum</param>
        /// <returns>True if there is a subset; otherwise false</returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-subset-sum-problem/"/>
        public static bool IsSubSetSum(int[] input, int sum)
        {
            int n = input.Length;

            bool[,] subset = new bool[n + 1, sum + 1];

            //if sum is 0, then answer is true
            for (int i = 0; i <= n; i++)
                subset[i, 0] = true;

            //if sum is not 0 and set is empty, then answer is false
            for (int i = 1; i <= sum; i++)
                subset[0, i] = false;

            // Fill the subset table in bottom up manner
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    subset[i, j] = subset[i - 1, j];

                    if (j >= input[i - 1] && subset[i, j] == false)
                        subset[i, j] = subset[i, j]
                                    || subset[i - 1, j - input[i - 1]];
                }
            }

            //un-comment for print the matrix
            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= sum; j++)
            //    {
            //        Debug.Write(subset[i, j] + "\t");
            //    }

            //    Debug.WriteLine("");
            //}

            return subset[n, sum];
        }   
    }
}
