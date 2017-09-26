/*
 * @autor: Some smart guy on internet
 * @date: 04/24/2016
 * @project: The Coding Interview
 *
 */

using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Print a given matrix in spiral form
    /// </summary>
    /// <example>
    /// Input:
    ///    1   2   3   4  5   6
    ///    7   8   9  10  11  12
    ///   13  14  15 16  17  18
    /// Output:
    /// 1 2 3 4 5 6 12 18 17 16 15 14 13 7 8 9 10 11
    /// </example>
    public static class MatrixInSpiral
    {
        /// <summary>
        /// Given a 2D array, print it in spiral form.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The spiral spiral form of the matrix</returns>
        /// <example>
        /// Input:
        /// 1    2   3   4
        /// 5    6   7   8
        /// 9   10  11  12
        /// 13  14  15  16
        ///
        /// Output:
        /// 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10
        /// </example>
        /// <remarks>Time Complexity: O(mn)</remarks>
        /// <see cref="http://www.geeksforgeeks.org/print-a-given-matrix-in-spiral-form/"/>
        /// TODO: Fix this code to accept MxN not only NxN
        public static string Print( int[,] input )
        {
            int length = input.GetLength (0) - 1;

            string output = string.Empty;

            //iterate over the matrix length/2
            for (int i = 0 ; i < input.GetLength (0) / 2 ; i++)
            {
                int k = length - i; //current bound

                //row -> left to rigth
                for (int j = i ; j < k ; j++)
                    Show (input[i, j], ref output);

                //right column -> downwards
                for (int j = i ; j < k ; j++)
                    Show (input[j, k], ref output);

                //row -> right to left
                for (int j = k ; j > i ; j--)
                    Show (input[k, j], ref output);

                //left column -> bottom up
                for (int j = k ; j > i ; j--)
                    Show (input[j, i], ref output);
            }

            if (input.GetLength (0) % 2 == 1)
                Show (input[input.GetLength (0) / 2, input.GetLength (0) / 2], ref output);

            return output.TrimEnd ();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <param name="s1"></param>
        private static void Show( int input, ref string s1 )
        {
            Debug.Write (string.Format ("{0} ", input));
            s1 += input + " ";
        }
    }
}