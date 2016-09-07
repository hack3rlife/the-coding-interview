/*
 * @autor: Some smart guy on internet
 * @date: 05/03/2016
 * @project: SquareRoot
 * 
 */

namespace com.hack3rlife.math
{
    /// <summary>
    /// In mathematics, a square root of a number a is a number y such that y2 = a, in other words, a number y whose square (the result of multiplying the number by itself, or y × y) is a.
    /// The most common iterative method of square root calculation by hand is known as the "Babylonian method" or "Heron's method"
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Methods_of_computing_square_roots"/>
    /// <seealso cref="https://en.wikipedia.org/wiki/Square_root"/>
    public static class SquareRoot
    {
        /// <summary>
        /// Get the SquareRoot of a given number using Babylonian method: 
        ///     Rx+1 = (Rx + (N/Rx))/2
        ///         where
        ///             N = Number that want to get the square root
        ///             Rx = Initial Guess
        /// </summary>
        /// <param name="number">Number to be square rooted</param>
        /// <returns>The square root of the given number</returns>
        public static double Get(double number)
        {
            if (number <= 0)
                return 0;

            //Store the value for Rx+1
            double current = GetInitialGuess(number);
            //Store the Rx values
            double previous = 0;

            //While Rx and Rx+1 be differents
            while (current != previous)
            {
                // Rx    =  Rx+1
                previous = current;
                // Rx+1 = (   Rx    +   N    /    Rx   ) / 2
                current = (previous + number / previous) / 2;
            }

            return current;
        }

        /// <summary>
        /// Get an initial guess obtaining the closest quadratic number to the given number
        /// </summary>
        /// <param name="number">Number to be square rooted</param>
        /// <returns>The closest number (to the square) to the given number </returns>
        private static int GetInitialGuess(double number)
        {
            int i = 0;
            while (i * i < number)
                i++;

            return i - 1;
        }

    }
}