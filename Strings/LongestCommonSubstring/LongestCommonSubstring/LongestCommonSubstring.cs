/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2015
 * @project: LongestCommonSubstring
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// In computer science, the longest common substring problem is to find the longest string (or strings) that is a substring (or are substrings) of two or more strings.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Longest_common_substring_problem"/>    
    /// <example>The longest common substring of the strings "ABABC", "BABCA" and "ABCBA" is string "ABC" of length 3. Other common substrings are "A", "AB", "B", "BA", "BC" and "C".</example>
    public class LongestCommonSubstring
    {
        /// <summary>
        /// Finds the set of longest common substrings between two strings with dynamic programming:
        /// </summary>
        /// <param name="input1">The input string one</param>
        /// <param name="input2">The input string two</param>
        /// <remarks>The longest common substrings of a set of strings can be found by building a generalised suffix tree for the strings, and then finding the deepest internal nodes which have leaf nodes from all the strings in the subtree below it. </remarks>
        /// <returns>The length of the longest common substring</returns>
        /// <!--Given two strings, S of length m and T of length n, find the longest strings which are substrings of both S and T.-->
        public static int GetLength(string input1, string input2)
        {
            int m = input1.Length;
            int n = input2.Length;

            int[,] num = new int[m, n];

            int max = 0;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if(input1[i] == input2[j])
                    {
                        if (i == 1 || j == 1)
                        {
                            num[i, j] = 1;
                        }
                        else {
                            num[i, j] = num[i - 1, j - 1] + 1;
                        }

                        max = (max > num[i, j]) ? max : num[i, j];
                    }
                    else
                    {
                        num[i, j] = 0;
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the set of longest common substrings between two strings with dynamic programming:
        /// </summary>
        /// <param name="input1">The input string one</param>
        /// <param name="input2">The input string two</param>
        /// <remarks>The longest common substrings of a set of strings can be found by building a generalised suffix tree for the strings, and then finding the deepest internal nodes which have leaf nodes from all the strings in the subtree below it. </remarks>
        /// <returns>The substring of the longest common substring</returns>
        /// <!--Given two strings, S of length m and T of length n, find the longest strings which are substrings of both S and T.-->
        public static System.Collections.Generic.List<string>  GetSubstring(string input1, string input2)
        {
            int m = input1.Length;
            int n = input2.Length;

            int[,] num = new int[m, n];

            int max = 0;
            System.Collections.Generic.List<string> result = new System.Collections.Generic.List<string>();

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (input1[i] == input2[j])
                    {
                        if (i == 1 || j == 1)
                        {
                            num[i, j] = 1;
                        }
                        else {
                            num[i, j] = num[i - 1, j - 1] + 1;
                        }

                        //if there is a longer common substring, update max value, clear the actual result list and update it. 
                        if (num[i, j] > max)
                        {
                            max = num[i, j];
                            result.Clear();
                            result.Add(input1.Substring(i - max, max + 1));
                        }
                        //if there is another long common substring, add it to the result it
                        else if (num[i, j] == max)
                        {
                            result.Add(input1.Substring(i - max, max + 1));
                        }
                    }
                    else
                    {
                        num[i, j] = 0;
                    }
                }
            }
            return result;
        }
    }
}
