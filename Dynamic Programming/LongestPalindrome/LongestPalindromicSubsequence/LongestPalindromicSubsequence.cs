/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2016
 * @project: LongestPalindromicSubsequence
 * 
 */

using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// The longest palindromic subsequence (LPS) problem is the problem of finding the longest subsequence of a string (a subsequence is obtained by deleting some of the characters from a
    /// string without reordering the remaining characters) which is also a palindrome. In general, the longest palindromic subsequence is not unique.
    /// </summary>
    /// <example>
    /// The string alfalfa has four palindromic subsequences of length 5: alala, afafa, alfla, and aflfa
    /// </example>
    /// <see cref="http://techieme.in/longest-palindromic-subsequence/"/>
    /// <seealso cref="http://wcipeg.com/wiki/Longest_palindromic_subsequence"/>
    public static class LongestPalindromicSubsequence
    {
        /// <summary>
        /// Given a string, find longest palindromic subsequence in this string.
        /// </summary>
        /// <example>
        /// Input: "agbdba"
        /// Output: 5
        /// </example>
        /// <returns>The length of the longest palindromic subsequence</returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-12-longest-palindromic-subsequence/"/>
        /// <seealso cref="https://www.youtube.com/watch?v=_nCsPn7_OgI"/>
        public static int GetLength(string input)
        {
            int m = input.Length;

            int[,] res = new int[m, m];

            // Strings of length 1 are palindrome of lentgh 1
            for (int i = 0; i < m; i++)
                res[i, i] = 1;

            //finding palindromes of length 2 to n
            for (int l = 2; l <= m; l++)
            {
                for (int i = 0; i < m - l + 1; i++)
                {
                    var j = l + i - 1;

                    if (input[i] == input[j] && l == 2)                 //if there are only 2 characters and both are same
                    {
                        res[i, j] = 2;
                    }
                    else if (input[i] == input[j])                      //if there are more than two characters and first and last are same
                    {
                        res[i, j] = res[i + 1, j - 1] + 2;
                    }
                    else                                                //if there are more than two characters and first and last are not same
                    {
                        res[i, j] = GetMax(res[i, j - 1], res[i + 1, j]);
                    }
                }
            }

            Print(res);
            return res[0, m - 1];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

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
