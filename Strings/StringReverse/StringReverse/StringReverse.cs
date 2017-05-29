/*
 * @autor: Some smart guy on internet
 * @date: 13/01/2015
 * @project: String Reverse
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// Implemetns differentes approches to reverse a given string
    /// </summary>
    public static class StringReverse
    {
        /// <summary>
        /// String reverse using a temporal array
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>The reversed string</returns>
        public static string Reverse(string input)
        {
            if (input.Length <= 0 || input == null)
                return string.Empty;

            char[] result = new char[input.Length];

            for (int i = 0, j = input.Length - 1; i <= j; i++, j--)
            {
                result[i] = input[j];
                result[j] = input[i];
            }

            return new string(result);
        }

        /// <summary>
        /// String reverse using XOR operator
        /// </summary>
        /// <param name="input">The string in a array of chars</param>
        /// <returns>The reversed string</returns>
        public static string Reverse(char[] input)
        {
            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {
                input[i] ^= input[j];
                input[j] ^= input[i];
                input[i] ^= input[j];

                i++;
                j--;
            }

            return new string(input);
        }

        /// <summary>
        /// String reverse using recursion
        /// </summary>
        /// <param name="input">The string in a array of chars</param>
        /// <param name="i">left index</param>
        /// <param name="j">rigth index</param>
        /// <returns>The reversed string</returns>
        public static string Reverse(char[] input, int i, int j)
        {
            if (i == j || i > j || i > input.Length || j < 0)
                return new string(input);

            input[i] ^= input[j];
            input[j] ^= input[i];
            input[i] ^= input[j];

            return Reverse(input, i + 1, j - 1);
        }

        public static string ReverseWordsInASentece(string input)
        {
            var reversed = Reverse(input.ToCharArray());

            string reversedWords = string.Empty;

            string result = string.Empty;

            for (int i = 0; i < reversed.Length; i++)
            {
                if (reversed[i] != ' ')
                {
                    result += reversed[i];
                }
                else
                {
                    result = reversed[i] + result;
                    reversedWords += Reverse(result);
                    result = string.Empty;
                }
            }
            return reversedWords + Reverse(result);
        }
    }
}
