/*
 * @autor: Some smart guy in the milky way
 * @date: 21/04/2016
 * @project: LongestCommonSubstring
 * 
 */

namespace com.hack3rlife.strings
{
    public static class LongestPalindromicSubsequence
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-12-longest-palindromic-subsequence/"/>
        public static int GetLength(string input)
        {
            int m = input.Length;

            int[,] res = new int[m, m];

            // Strings of length 1 are palindrome of lentgh 1
            for (int i = 0; i < m; i++)
                res[i, i] = 1;

            for (int l = 2; l <= m; l++)
            {
                for (int i = 0; i < m - l+1; i++)
                {
                    var j = l + i - 1;

                    //finding palindromes of length 2 to n
                    if (input[i] == input[j] && l == 2)
                    {
                        res[i, j] = 2;
                    }
                    //trim if match + 2
                    else if (input[i] == input[j])
                    {
                        res[i, j] = res[i + 1, j - 1] + 2;
                    }
                    //trim one at the time and take max
                    else
                    {
                        res[i, j] = max(res[i, j - 1], res[i + 1, j]);
                    }
                }
            }

            return res[0, m - 1];
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
    }
}
