using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.stringpermutation
{
    /// <summary>
    /// 
    /// </summary>
    public class StringPermutation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public static void Permute(string input)
        {
            Permutation(input.ToCharArray(), 0);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="input"></param>
        /// <param name="current"></param>
        private static void Permutation(char[] input, int current)
        {
            if (current == input.Length - 1)
            {
                Console.WriteLine(input);
                return;
            }

            for (int i = current; i < input.Length; i++)
            {
                input = Swap(input, current, i);
                Permutation(input, current + 1);
                input = Swap(input, current, i);
            }
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private static char[] Swap(char[] input, int i, int j)
        {
            if (i != j)
            {
                input[i] ^= input[j];
                input[j] ^= input[i];
                input[i] ^= input[j];
            }

            return input;
        }
    }
}
