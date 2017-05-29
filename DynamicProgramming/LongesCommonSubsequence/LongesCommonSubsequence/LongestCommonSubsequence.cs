/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2015
 * @project: LongesCommonSubsequence
 * 
 */

using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// The longest common subsequence (LCS) problem is the problem of finding the longest subsequence common to all sequences in a set of sequences (often just two sequences). It differs 
    /// from problems of finding common substrings: unlike substrings, subsequences are not required to occupy consecutive positions within the original sequences. The longest common 
    /// subsequence problem is a classic computer science problem, the basis of data comparison programs such as the diff utility, and has applications in bioinformatics. 
    /// It is also widely used by revision control systems such as Git for reconciling multiple changes made to a revision-controlled collection of files.    
    /// </summary>
    /// <see cref=">https://en.wikipedia.org/wiki/Longest_common_subsequence_problem"/>
    /// <seealso cref="https://www.ics.uci.edu/~eppstein/161/960229.html"/>
    public static class LongestCommonSubsequence
    {
        /// <summary>
        /// Given two sequences, find the length of longest subsequence present in both of them. A subsequence is a sequence that appears in the same relative order, but not necessarily 
        /// contiguous. For example, “abc”, “abg”, “bdf”, “aeg”, ‘”acefg”, .. etc are subsequences of “abcdefg”. So a string of length n has 2^n different possible subsequences.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <example>
        /// LCS for input Sequences “ABCDGH” and “AEDFHR” is “ADH” of length 3.
        /// LCS for input Sequences “AGGTAB” and “GXTXAYB” is “GTAB” of length 4.
        /// </example>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-4-longest-common-subsequence/"/>
        public static int GetLength(string x, string y)
        {
            int m = x.Length;
            int n = y.Length;

            int[,] num = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // if curr char is the same in both string
                    if (x[i - 1] == y[j - 1])
                    {
                        //num[i, j] is equal to the top left diagonal value + 1
                        num[i, j] = num[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        //num[i, j] = max(left cell, top cell)
                        num[i, j] = max(num[i - 1, j], num[i, j - 1]);
                    }

                    Print(num);
                }
            }

            Print(num);

            return num[m, n];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/printing-longest-common-subsequence/"/>
        public static string GetSubsequence(string x, string y)
        {
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int max(int a, int b)
        {
            return a > b ? a : b;
        }

        ////public static int LcsNaive(string x, string y, int m, int n)
        ////{
        ////    if (m == 0 || n == 0)
        ////    {
        ////        return 0;
        ////    }

        ////    if (x[m - 1] == y[n - 1])
        ////    {
        ////        return 1 + LcsNaive(x, y, m - 1, n - 1);
        ////    }
        ////    else
        ////    {
        ////        return max(LcsNaive(x, y, m, n - 1), LcsNaive(x, y, m - 1, n));
        ////    }
        ////}


        /// <summary>
        /// Print the temporal DPT
        /// </summary>
        /// <param name="matrix">The table</param>
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Debug.Write(string.Format("{0} ", matrix[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }
    }
}
