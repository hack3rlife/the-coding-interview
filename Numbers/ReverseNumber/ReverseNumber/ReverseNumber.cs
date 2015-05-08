using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.numbers
{
    public class ReverseNumber
    {
        public static int Reverse(int number)
        {
            int quotient = number;
            int remainder = 0;
            int result = 0;

            do
            {
                remainder = quotient % 10;
                quotient /= 10;

                result = (result * 10) + remainder;

            } while (quotient > 0);

            return result;
        }

    }
}
