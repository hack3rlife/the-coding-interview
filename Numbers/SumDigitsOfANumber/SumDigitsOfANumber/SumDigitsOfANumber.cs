/*
 * @autor: Some smart guy on internet
 * @date: 05/102015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hack3rlife.numbers
{
    /// <summary>
    /// Sum the digits of a number 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Digit_sum"/>
    public class SumDigitsOfANumber
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int SumDigits(int number)
        {
            int result = 0;

            do
            {
                result = 0;

                while (number > 0)
                {
                    result += number % 10;
                    number /= 10;
                }

                number = result;

            } while (number > 10);

            return result;
        }
    }
}
