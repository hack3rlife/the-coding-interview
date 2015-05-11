using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.numbers
{
    public class FibonacciNumber
    {
        /// <summary>
        /// Get the Fibbonacci Number
        /// </summary>
        /// <param name="number">Integer Value</param>
        /// <returns>The Fibonnacci Number</returns>
        public static int Fibonacci(int number)
        {
            if (number <= 2)
                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        /// <summary>
        /// Get the Fibonacci Sequence of a number
        /// </summary>
        /// <param name="number">Integer Value</param>
        public static List<int> FibonacciSequence(int number)
        {
            List<int> result = new List<int>() { 0 };

            for (int i = 1; i <= number; i++)
                result.Add(Fibonacci(i));

            return result;
        }
    }
}
