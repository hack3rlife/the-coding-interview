using System;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// In computational complexity theory, the 3SUM problem asks if a given set of {\displaystyle n} n real numbers contains three elements that sum to zero.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/3SUM"/>
    public static class ThreeSumProblem
    {
        /// <summary>
        /// Given an integer array of size N and an integer K. We have to find three array elements whose sum is equal to K.
        /// </summary>
        /// <param name="input">The sorted array</param>
        /// <param name="n">The sum</param>
        public static void FindTriplets( int[] input, int n )
        {
            var length = input.Length;

            for (int i = 0 ; i < length ; i++)
            {
                var left = i + 1;
                var right = length - 1;
                var a = input[i];
                var b = 0;
                var c = 0;

                while (left < right)
                {
                    b = input[left];
                    c = input[right];

                    if (a + b + c == n)
                    {
                        Console.WriteLine ($"{a} {b} {c}");
                        left++;
                        right--;
                    }
                    else if (a + b + c < n)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }
    }
}