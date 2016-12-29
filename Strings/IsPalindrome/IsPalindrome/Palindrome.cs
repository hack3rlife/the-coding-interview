/*
 * @autor: Some smart guy on internet
 * @date: 12/05/2015
 * @project: Palindrome
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Palindrome"/>
    public static class Palindrome
    {
        /// <summary>
        /// Given a string, write a function to check if it is palindrome or not.
        /// </summary>
        /// <example>“abba” is palindrome, but “abbc” is not palindrome.</example>
        /// <param name="input">the input string</param>
        /// <returns>True if the string is palindrome; otherwise false</returns>
        /// <see cref=">http://quiz.geeksforgeeks.org/c-program-check-given-string-palindrome/"/>
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
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
    }
}
