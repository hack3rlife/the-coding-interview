/*
 * @autor: Some smart guy on internet
 * @date: 13/01/2015
 * @project: String Combination
 * 
 */

using System;
using System.Diagnostics;

namespace com.hack3rlife.strings
{
    /// <summary>
    /// In mathematics, a combination is a way of selecting items from a collection, such that (unlike permutations) the order of selection does not matter.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Combination"/>
    public class StringCombination
    {
        /// <summary>
        /// Find all possible combinations of the given string without duplicates and in lexicographic order
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetAllCombinations(string input)
        {
            var output = Combine(input, string.Empty, 0, string.Empty);
            return output.TrimStart();
        }

        /// <summary>
        /// Print all possible strings of length k that can be formed from a set of n characters
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <![CDATA[
        /// Input: set[] = {'a', 'b'}, k = 3
        /// Output:
        ///     aaa
        ///     aab
        ///     aba
        ///     abb
        ///     baa
        ///     bab
        ///     bba
        ///     bbb
        /// ]]>
        /// <returns></returns>
        public static string GetAllCombinationsOfLengthK(string input, int k)
        {
            var output = Combine(input, string.Empty, string.Empty, k);
            return output.TrimStart();

        }

        /// <summary>
        /// Print all possible combinations of r elements in a given array of size n 
        /// </summary>
        /// <![CDATA[
        /// if input = {1, 2, 3, 4} and r is then output should be {1, 2}, {1, 3}, {1, 4}, {2, 3}, {2, 4} and {3, 4}.
        /// 
        /// ]]>
        /// <see cref="http://www.geeksforgeeks.org/print-all-possible-combinations-of-r-elements-in-a-given-array-of-size-n/"/>
        /// <returns></returns>
        public static string Get()
        {
            return Combine();
        }

        /// <summary>
        /// Write an algorithm to print all possible combinations of characters in a string
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="currOutput">The current output, which normally starts as empty string</param>
        /// <param name="currentIndex">The current index, which normally start at 0</param>
        /// <param name="output">Current string result in the recusion stack</param>
        /// <returns>An string with all possible combinations without duplicates and in lexicographic order</returns>
        private static string Combine(string input, string currOutput, int currentIndex, string output)
        {
            for (int i = currentIndex; i < input.Length; i++)
            {
                currOutput += input[i];
                output += " " + currOutput;
                Debug.WriteLine(output);
                output = Combine(input, currOutput, i + 1, output);
                currOutput = currOutput.Remove(currOutput.Length - 1);
            }

            return output;
        }

        /// <summary>
        /// Given a set of characters and a positive integer k, print all possible strings of length k that can be formed from the given set.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="currOutput">The current output, which normally starts as empty string</param>
        /// <param name="output">Final string solution</param>
        /// <param name="k">Length of the set</param>
        /// <see cref="http://www.geeksforgeeks.org/print-all-combinations-of-given-length/"/>
        private static string Combine(string input, string currOutput, string output, int k)
        {
            if (k == 0)
            {
                Debug.WriteLine(currOutput);
                return output += " " + currOutput;
            }

            for (int i = 0; i < input.Length; i++)
            {
                var temp = currOutput + input[i];
                output = Combine(input, temp, output, k - 1);
            }

            return output;
        }

        /// <summary>
        /// Given an array of size n, generate and print all possible combinations of r elements in array. For example, if input array is {1, 2, 3, 4} and r is 2, then output should be {1, 2}, {1, 3}, {1, 4}, {2, 3}, {2, 4} and {3, 4}.
        /// </summary>
        /// <returns></returns>
        private static string Combine()
        {
            throw new NotImplementedException();
        }
    }
}
