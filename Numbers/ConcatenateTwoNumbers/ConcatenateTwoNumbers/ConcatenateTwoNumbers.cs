/*
 * @autor: Some smart guy on internet
 * @date: 05/08/2015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hack3rlife.numbers
{
    public static class ConcatenateTwoNumbers
    {
        /// <summary>
        /// Concatenate two numbers
        /// </summary>
        /// <param name="a">Integer value</param>
        /// <param name="b">Integer value</param>
        /// <returns>The sum of the two numbers</returns>
        public static int Concatenate(int number1, int number2)
        {
            int c = number2;
            while (c > 0)
            {
                //make room for number2 or add 0's to its right
                number1 *= 10;
                c /= 10;
            }

            return number1 + number2;
        }

    }
}
