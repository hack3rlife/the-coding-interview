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
        /// Checks if a pair of string are anagrams assuming the string use ASCII endoding.
        /// </summary>
        /// <param name="source">The input string one</param>
        /// <param name="target">The input string two</param>
        /// <returns>True if input strings are anagrams; otherwise false.</returns>
        /// <see cref="https://www.careercup.com/question?id=8641795"/>
        public static bool ASCIIBasedSolution( string source, string target)
        {
            if (source.Length == 0 && target.Length == 0)
                return true;

            if (source.Length <= 0 || target.Length <= 0)
                return false;

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
    }
}
