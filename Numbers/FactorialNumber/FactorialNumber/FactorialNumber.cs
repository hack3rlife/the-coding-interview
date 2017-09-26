/*
 * @autor: Some smart guy on internet
 * @date: 05/10/2015
 * @project: ConcatenateTwoNumbers
 *
 */

using System.Diagnostics;

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
        /// <returns>The Factorial Number</returns>
        public static long Factorial( int number )
        {
            if (number <= 1)
                return 1;
            else
                return Factorial(number - 1) * number;
        }

        public static int FactorialDP( int number )
        {
            int[] output;

            if (number <= 1)
            {
                return 1;
            }
            else
            {
                output = new int[number+1];
                output[0] = 1;
                output[1] = 1;

                for (int i = 2; i < output.Length; i++)
                {
                    output[i] = i * output[i - 1];
                    Debug.Write($" {output[i]} ");
                }

                Debug.WriteLine("");
            }
            return output[number];
        }
    }
}