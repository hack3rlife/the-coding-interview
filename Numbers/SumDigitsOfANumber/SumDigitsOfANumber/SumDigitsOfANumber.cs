/*
 * @autor: Some smart guy on internet
 * @date: 05/102015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hack3rlife.numbers
{
    /// <summary>
    /// 
    /// </summary>
    public class SumDigitsOfANumber
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int SumDigits(int number)
        {
            int result;

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
