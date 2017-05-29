/*
 * @autor: Some smart guy on internet
 * @date: 05/16/2015
 * @project: String Combination
 * 
 */

using System;

namespace com.hack3rlife.strings
{
    /// <summary>
    /// In computer science, the Knuth–Morris–Pratt string searching algorithm (or KMP algorithm) searches for occurrences of a "word" W within a main "text string" S by employing the 
    /// observation that when a mismatch occurs, the word itself embodies sufficient information to determine where the next match could begin, thus bypassing re-examination of previously
    /// matched characters.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm"/>
    /// <seealso cref="https://en.wikipedia.org/wiki/String_searching_algorithm"/>
    public class KMPAlgorithm
    {
        static int[] lps;

        /// <summary>
        /// Given a text input[0..n-1] and a pattern pattern[0..m-1], write a function Search(string input, string pattern) that prints all occurrences of pattern[] in input[]. You may 
        /// assume that n > m.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="pattern">The patter to search</param>
        /// <returns>The index where the pattern starts; otherwise null</returns>
        /// <example> input[] =  "THIS IS A TEST TEXT", pattern[] = "TEST", output:10</example>
        /// <see cref="http://www.geeksforgeeks.org/searching-for-patterns-set-2-kmp-algorithm/"/>
        public static int Search(string input, string pattern)
        {
            int patternLength = pattern.Length;
            int inputLength = input.Length;

            int index = -1;

            CalculateLpsArray(pattern);

            int i = 0;
            int j = 0;

            while (i < inputLength)
            {
                if (input[i] == pattern[j])
                {
                    i++;
                    j++;
                }

                if (j == patternLength - 1)
                {
                    Console.WriteLine("Found pattern at index: {0}", i - j);
                    index = i - j;
                    j = lps[j - 1];
                }
                else if (i < inputLength && input[i] != pattern[j])  // mismatch after j matches
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }


            return index;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pattern"></param>
        private static void CalculateLpsArray(string pattern)
        {
            int length = 0;
            int i = 1;

            lps = new int[pattern.Length];
            lps[0] = 0;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[length])
                {
                    lps[i++] = ++length;
                }
                else
                {
                    if (length != 0)
                    {
                        length = lps[length - 1];
                    }
                    else
                    {
                        lps[i++] = 0;
                    }
                }
            }
        }
    }
}