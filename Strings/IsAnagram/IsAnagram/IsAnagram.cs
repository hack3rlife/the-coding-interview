/*
 * @autor: Some smart guy on internet
 * @date: 12/05/2015
 * @project: String Combination
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// An anagram is a type of word play, the result of rearranging the letters of a word or phrase to produce a new word or phrase, using all the original letters exactly once;
    /// for example, the word anagram can be rearranged into nag-a-ram.
    /// 
    /// Any word or phrase that exactly reproduces the letters in another order is an anagram
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Anagram"/>
    public class IsAnagram
    {
        /// <summary>
        /// Write a function to check whether two given strings are anagram of each other or not. An anagram of a string is another string that contains same characters, only the order of 
        /// characters can be different
        /// </summary>
        /// <param name="source">The input string one</param>
        /// <param name="target">The input string two</param>
        /// <example>“abcd” and “dabc” are anagram of each other.</example>
        /// <returns>True if input strings are anagrams; otherwise false.</returns>
        /// <remarks>
        /// Time Complexity O(n)
        /// Space Complexity O(n)
        /// </remarks>
        /// <see cref="https://www.careercup.com/question?id=8641795"/>
        public static bool ASCIIBasedSolution(string source, string target)
        {
            if (source.Length == 0 && target.Length == 0)
                return true;

            if (source.Length != target.Length)
                return false;

            //I'm assuming the string could be any char represented in the ASCII Table
            int[] alphabet = new int[256];

            //Store every char and increment/decrement in one every repetition
            for (int i = 0; i < source.Length; i++)
            {
                alphabet[source[i]]++;
                alphabet[target[i]]--;
            }


            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] != 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Write a function to check whether two given strings are anagram of each other or not. An anagram of a string is another string that contains same characters, only the order of 
        /// characters can be different
        /// </summary>
        /// <param name="source">The input string one</param>
        /// <param name="target">The input string two</param>
        /// <example>“abcd” and “dabc” are anagram of each other.</example>
        /// <returns>True if input strings are anagrams; otherwise false.</returns>
        /// <remarks>
        /// Time Complexity O(n)
        /// Space Complexity O(n)
        /// </remarks>
        /// <see cref="http://www.geeksforgeeks.org/check-whether-two-strings-are-anagram-of-each-other/"/>
        public static bool XOrBasedSolution(string source, string target)
        {
            if (source.Length == 0 && target.Length == 0)
                return true;

            if (source.Length != target.Length)
                return false;

            int x = 0;
            int y = 0;
            for (int i = 0; i < source.Length; i++)
            {
                x ^= source[i];
                y ^= target[i];
            }

            return (x ^ y) == 0 ? true : false;
        }
    }
}
