/*
 * @autor: Some smart guy on internet
 * @date: 05/10/2015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hack3rlife.numbers
{
    /// <summary>
    /// In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n.  The value of 0! is 1, according to the 
    /// convention for an empty product.
    /// </summary>
    /// <example> 5! = 5*4*3*2*1 = 120.</example>
    /// <see cref="https://en.wikipedia.org/wiki/Factorial"/>
    public class FactorialNumber
    {
        /// <summary>
        /// Get the Factorial of any integer number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long Factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return Factorial(number - 1) * number;
        }
    }
}