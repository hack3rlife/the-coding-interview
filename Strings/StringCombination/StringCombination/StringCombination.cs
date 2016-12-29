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
        public static string Get(string input)
        {
            string result = string.Empty;

            StringCombination.Combine(input, string.Empty, 0, ref result);

            return result.TrimStart();
        }
        /// <summary>
        /// Find all possible combinations of the given string
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="output">The current output, which normally starts as empty string</param>
        /// <param name="current">The current index, which normally start at 0</param>
        /// <see cref="http://www.geeksforgeeks.org/print-all-possible-combinations-of-r-elements-in-a-given-array-of-size-n/"/>
        private static void Combine(string input, string output, int current, ref string result)
        {
            for (int i = current; i < input.Length; i++)
            {
                output += input[i];
                result += " " + output;
                Combine(input, output, i + 1, ref result);
                output = output.Remove(output.Length - 1);
            }
        }
    }
}
