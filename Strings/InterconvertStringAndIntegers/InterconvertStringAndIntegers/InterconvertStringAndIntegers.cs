/*
 * @autor: Elementes of Programming Interview
 * @date: 04/18/2016
 * @project: Number to String
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// Implments methods that take a string representing an integer and return the corresponding integer and viceversa.
    /// </summary>
    public static class InterconvertStringAndIntegers
    {
        /// <summary>
        /// Converts the given POSITIVE integer to its string representation.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns></returns>
        public static string ConvertToString(int input)
        {
            string output = string.Empty;

            do
            {
                //adding a digit to the beginnig of a strinng is expensive,
                //since all the remaining digits have to be moved. A more time 
                //efficient approach would be add each digit to the end and then
                //reverse the computed sequence
                output = input % 10 + output;
                input /= 10;

            } while (input > 0);

            return output;
        }

        /// <summary>
        /// Converts the given string to its POSITIVE integer representation.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns></returns>
        public static int ConvertToInt(string input)
        {
            return 0;
        }
    }
}
