/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2016
 * @project: LongestCommonSubstring
 * 
 */

using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// In computer science, the longest palindromic substring or longest symmetric factor problem is the problem of finding a maximum-length contiguous substring of a given string that is
    /// also a palindrome. For example, the longest palindromic substring of "bananas" is "anana". The longest palindromic substring is not guaranteed to be unique; for example, in the 
    /// string "abracadabra", there is no palindromic substring with length greater than three, but there are two palindromic substrings with length three, namely, "aca" and "ada". In some
    /// applications it may be necessary to return all maximal palindromic substrings (that is, all substrings that are themselves palindromes and cannot be extended to larger palindromic
    /// substrings) rather than returning only one substring or returning the maximum length of a palindromic substring.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Longest_palindromic_substring"/>
    public static class LongestPalindromicSubstring
    {
        /// <summary>
        /// Given a string, find the longest substring which is palindrome. 
        /// </summary>
        /// <param name="input">The input string</param>      
        /// <returns>The length of the longest substring which is palindrome.</returns>
        /// <example>If the given string is “forgeeksskeegfor”, the output should be “geeksskeeg”.</example>
        /// <see cref="http://www.geeksforgeeks.org/longest-palindrome-substring-set-1/"/>
        /// <seealso cref="https://www.youtube.com/watch?v=obBdxeCx_Qs"/>
        public static int GetLength(string input)
        {
            int m = input.Length;
            var max = 1;
            int[,] res = new int[m, m];

            // Strings of length 1 are palindrome of lentgh 1
            for (int i = 0; i < m; i++)
            {
                res[i, i] = 1;
                Print(res);
            }

            // check for sub-string of length 2.
            int start = 0;
            for (int i = 0; i < m - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    res[i, i + 1] = 1;
                    start = i;
                    max = 2;
                    Print(res);
                }
            }

            //Check for string lengths greater than 2.
            for (int l = 3; l <= m; l++)
            {
                for (int i = 0; i < m - l + 1; i++)
                {
                    // Get the ending index of substring from starting index i and length l
                    int j = i + l - 1;  

                    // checking for sub-string from ith index to jth index iff str[i+1] to str[j-1] is a palindrome
                    if (res[i + 1, j - 1] == 1 && input[i] == input[j])
                    {
                        res[i, j] = 1;

                        if (l > max)
                        {
                            start = i;
                            max = l;
                        }
                    }

                    Print(res);
                }
            }

            Print(res);

            return max;
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