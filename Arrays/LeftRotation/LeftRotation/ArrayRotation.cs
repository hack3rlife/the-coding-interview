using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Write a function rotate(arr[], d, n) that rotates arr[] of size n by d elements.
    /// </summary>
    /// <see cref="http://www.geeksforgeeks.org/array-rotation/"/>
    /// <seealso cref="http://www.geeksforgeeks.org/block-swap-algorithm-for-array-rotation/"/>
    public static class ArrayRotation
    {
        /// <summary>
        /// Naive Approach
        /// </summary>
        /// <param name="input">The input array</param>
        /// <param name="n">The number of left rotations</param>
        /// <returns>The left rotated array</returns>
        public static int[] LeftRotation( int[] input, int n )
        {
            int length = input.Length;

            for (int i = 0 ; i < n ; i++)
            {
                int curr = input[0];

                for (int j = 0 ; j < length - 1 ; j++)
                {
                    input[j] = input[j + 1];
                    Print (input);
                }

                input[length - 1] = curr;
                Print (input);
            }

            return input;
        }

        /// <summary>
        /// Move the items in an array to the left or right by some number of spaces, with values on the edges wrapping around to the other side. Rotations
        /// can be implemented as three reversals.
        /// </summary>
        /// <see cref="http://www.geeksforgeeks.org/program-for-array-rotation-continued-reversal-algorithm/"/>
        /// <seealso cref="https://en.wikipedia.org/wiki/Block_sort"/>
        public static int[] ReverseRotation( int[] input, int n )
        {
            int length = input.Length - 1;

            Print (input);

            Reverse (input, 0, n - 1);
            Reverse (input, n, length);
            Reverse (input, 0, length);

            return input;
        }

        /// <summary>
        /// Reverse the input array
        /// </summary>
        /// <param name="input">The inpur array</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        private static void Reverse( int[] input, int start, int end )
        {
            while (start < end)
            {
                input[start] ^= input[end];
                input[end] ^= input[start];
                input[start] ^= input[end];
                start++;
                end--;
            }
        }

        private static void Print( int[] input )
        {
            for (int i = 0 ; i < input.Length ; i++)
            {
                Debug.Write (string.Format (" {0} ", input[i]));
            }

            Debug.WriteLine ("");
        }
    }
}