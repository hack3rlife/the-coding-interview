/*
 * @autor: Elementes of Programming Interview
 * @date: 04/04/2016
 * @project: ReverseNumber
 * 
 */
namespace com.hack3rlife.numbers
{
    /// <summary>
    /// Implements reverse numbers
    /// </summary>
    public class ReverseNumber
    {
        /// <summary>
        /// Reverse the given number (This version only supports positive numbers)
        /// </summary>
        /// <param name="number">The input number</param>
        /// <returns>The reversed number based on the input number</returns>
        public static int Reverse(int number)
        {
            int result = 0;
            int remaining =  number;

            while (remaining > 0)
            {
                result = result * 10 + remaining % 10;
                remaining /= 10;
            }
            return result;
        }            

    }
}
