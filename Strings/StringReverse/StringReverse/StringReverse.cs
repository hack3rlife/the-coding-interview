/*
 * @autor: hack3rlife
 * @date: 13/01/2015
 * @project: Strings
 * 
 */

namespace com.hack3rlife.stringreverse
{
    public static class StringReverse
    {
        /// <summary>
        /// Reverse the string passed as parameter
        /// </summary>
        /// <param name="input">Input string</param>        
        /// <returns>Return a the param <para>input</para>reversed</returns>
        public static string Reverse(string input)
        {
            if (input.Length <= 0 || input == null)
                return string.Empty;

            string reversed = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
                reversed += input[i];

            return reversed;
        }

        /// <summary>
        /// Reverse a string (Optimized version)
        /// </summary>
        /// <param name="input">Input String</param>
        /// <returns>Return a the param <para>input</para>reversed</returns>
        public static string ReverseOptimized(string input)
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
    }
}
