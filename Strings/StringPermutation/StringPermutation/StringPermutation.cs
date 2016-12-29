/*
 * @autor: Some smart guy on internet
 * @date: 13/01/2015
 * @project: String Permutation
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// A permutation is an arrangement of objects in specific order. The order of the arrangement is important!
    /// 
    /// The number of permutations of n distinct objects is n factorial usually written as n!, which means the product of all positive integers less than or equal to n.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Permutation"/>
    public class StringPermutation
    {
        /// <summary>
        /// Permutates the given string
        /// </summary>
        /// <param name="input">The input string</param>
        /// <seealso cref="http://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/"/>
        /// <![CDATA[
        /// input: ABC
        /// output: ABC ACB BAC BCA CBA CAB]]>        
        public static string Permute(string input)
        {
            var output = string.Empty;
            Permutation(input.ToCharArray(), 0, ref output);

            return output.TrimEnd();
        }

        /// <summary>
        /// Recursive solution to get all permutations without duplicates allowed
        /// </summary>
        /// <param name="input">The input string as array of chars</param>
        /// <param name="current">The start position. </param>
        private static void Permutation(char[] input, int current, ref string output)
        {
            if (current == input.Length - 1)
            {
                output += new string(input) + " ";
                return;
            }

            for (int i = current; i < input.Length; i++)
            {
                Swap(input, current, i);
                Permutation(input, current + 1, ref output);
                Swap(input, current, i);
            }
        }

        /// <summary>
        /// Swap the values in the array
        /// </summary>
        /// <param name="input">The input array</param>
        /// <param name="i">The left index</param>
        /// <param name="j">The right index</param>
        private static void Swap(char[] input, int i, int j)
        {
            if (i != j)
            {
                input[i] ^= input[j];
                input[j] ^= input[i];
                input[i] ^= input[j];
            }
        }
    }
}
