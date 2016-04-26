/*
 * @autor: Some smart guy on internet
 * @date: 05/10/2015
 * @project: ConcatenateTwoNumbers
 * 
 */

using System.Collections.Generic;

namespace com.hack3rlife.numbers
{
    /// <summary>
    /// In mathematics, the Fibonacci numbers or Fibonacci sequence are the numbers in the following integer sequence: 1,1,2,3,5,8,13,21,34,55,89,144, ...
    /// By definition, the first two numbers in the Fibonacci sequence are either 1 and 1, or 0 and 1, depending on the chosen starting point of the sequence, and each subsequent number is
    /// the sum of the previous two.  In mathematical terms, the sequence Fn of Fibonacci numbers is defined by the recurrence relation Fn = F{n-1} + F{n-2}, with seed values F1 = 1, F2 = 1
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Fibonacci_number"/>
    public class FibonacciNumber
    {
        /// <summary>
        /// Get the Fibbonacci Number
        /// </summary>
        /// <param name="number">Integer Value</param>
        /// <returns>The Fibonnacci Number</returns>
        public static int Fibonacci(int number)
        {
            if (number <= 1)
                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        /// <summary>
        /// Dynamic Programming Solution
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The Fibonnacci number</returns>
        public static int FibonacciDynamic(int number)
        {
            int[] result = new int[number + 1];

            result[0] = 0;
            result[1] = 1;

            for (int  i = 2; i <= number; i++)
            {
                // Add the previous 2 numbers in the series and store it
                result[i] = result[i - 1] + result[i - 2];
            }

            return result[number];
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