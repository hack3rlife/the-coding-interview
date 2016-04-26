/*
 * @autor: Some smart guy on internet
 * @date: 13/01/2015
 * @project: String Combination
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// In mathematics, a combination is a way of selecting items from a collection, such that (unlike permutations) the order of selection does not matter.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Combination"/>
    public class StringCombination
    {
        /// <summary>
        /// Stores the result
        /// </summary>
        public static System.Collections.Generic.List<string> Result = new System.Collections.Generic.List<string>();

        /// <summary>
        /// Find all possible combinations of the given string
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="output">The current output, which normally starts as empty string</param>
        /// <param name="current">The current index, which normally start at 0</param>
        /// <see cref="http://www.geeksforgeeks.org/print-all-possible-combinations-of-r-elements-in-a-given-array-of-size-n/"/>
        public static void Combine(string input, string output = "", int current = 0)
        {
            for (int i = current; i < input.Length; i++)
            {
                output += input[i];
                Result.Add(output);
                Combine(input, output, i + 1);
                output = output.Remove(output.Length - 1);
            }
        }
    }
}
