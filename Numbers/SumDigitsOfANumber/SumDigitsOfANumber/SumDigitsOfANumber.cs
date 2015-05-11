using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.numbers
{
    public class SumDigitsOfANumber
    {
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
