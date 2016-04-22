/*
 * @autor: Some smart guy in the milky way
 * @date: 12/05/2015
 * @project: Palindrome
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. 
    /// 
    /// </summary>
    public class Palindrome
    {
        /// <summary>
        ///  Check whether a string is palindrome or not
        /// </summary>
        /// <param name="input">the input string</param>
        /// <returns>True if the string is palindrome; otherwise false</returns>
        public static bool IsPalindrome(string input)
        {
            if (input == string.Empty || input.Length <= 1)
                return false;

            int i = 0, j = input.Length - 1;
            while (i < j)
            {
                //ignore blank spaces
                while (i < input.Length && input[i] == ' ')
                    i++;
                while (j >= 0 && input[j] == ' ')
                    j--;

                if (i >= input.Length || j < 0 || input[i] != input[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-12-longest-palindromic-subsequence/"/>
        public static string LonguestPalindrome(char[] input)
        {
                        return string.Empty;
        }
    }
}
