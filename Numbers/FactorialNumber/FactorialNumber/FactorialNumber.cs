
using System;
namespace com.hack3rlife.numbers
{
    public class FactorialNumber
    {
        public static int Factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return Factorial(number - 1) * number;
        }
    }
}