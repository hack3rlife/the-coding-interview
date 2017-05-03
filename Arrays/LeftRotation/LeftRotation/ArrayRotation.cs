using System.Diagnostics;

namespace LeftRotation
{
    /// <summary>
    /// Write a function rotate(arr[], d, n) that rotates arr[] of size n by d elements.
    /// </summary>
    /// 
    public static class ArrayRotation
    {
        /// <summary>
        /// Naive Approach
        /// </summary>
        /// <param name="input"></param>
        /// <param name="length"></param>
        /// <param name="n"></param>
        public static int[] LeftRotation(int[] input, int n)
        {
            int length = input.Length;

            for (int i = 0; i < n; i++)
            {
                int curr = input[0];

                for (int j = 0; j < length - 1; j++)
                {
                    input[j] = input[j + 1];
                    Print(input);
                }

                input[length - 1] = curr;
                Print(input);
            }

            return input;
        }

        /// <summary>
        /// Move the items in an array to the left or right by some number of spaces, with values on the edges wrapping around to the other side. Rotations
        /// can be implemented as three reversals.
        /// </summary>
        /// <see cref="https://en.wikipedia.org/wiki/Block_sort"/>
        public static int[] ReverseRotation(int[] input, int n)
        {
            int length = input.Length - 1;

            Print(input);

            Reverse(input, 0, n - 1);
            Reverse(input, n, length);
            Reverse(input, 0, length);

            return input;
        }

        private static void Reverse(int[] input, int start, int end)
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

        private static void Print(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Debug.Write(string.Format(" {0} ", input[i]));
            }

            Debug.WriteLine("");
        }
    }
}
