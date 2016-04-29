/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2016
 * @project: LongestCommonSubstring
 * 
 */

namespace com.hack3rlife.strings
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
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/longest-palindrome-substring-set-1/"/>
        public static int GetLength(string input)
        {
            int m = input.Length;
            var max = 0;
            bool[,] res = new bool[m, m];

            // Strings of length 1 are palindrome of lentgh 1
            for (int i = 0; i < m; i++)
            {
                res[i, i] = true;
            }

            // check for sub-string of length 2.
            int start = 0;
            for (int i = 0; i < m - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    res[i, i + 1] = true;
                    start = i;
                    max = 2;
                }
            }

            //Check for lengths greater than 2.
            for (int l = 3; l <= m; l++)
            {
                // Fix the starting index
                for (int i = 0; i < m - l + 1; i++)
                {
                    // Get the ending index of substring from
                    // starting index i and length k
                    int j = i + l - 1;

                    // checking for sub-string from ith index to
                    // jth index iff str[i+1] to str[j-1] is a
                    // palindrome
                    if (res[i + 1, j - 1] && input[i] == input[j])
                    {
                        res[i, j] = true;

                        if (l > max)
                        {
                            start = i;
                            max = l;
                        }
                    }
                }
            }
            return max;
        }
    }
}