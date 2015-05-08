using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.numbers
{
    public class ConcatenateTwoNumbers
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
                number1 *= 10;
                c /= 10;
            }

            return number1 + number2;
        }

    }
}
