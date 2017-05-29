/*
 * @autor: Some smart guy on internet
 * @date: 04/24/2016
 * @project: RotateMatrix
 * 
 */

using System;
using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Turn an image by 90 degree
    /// </summary>
    /// <seealso cref="http://www.geeksforgeeks.org/inplace-m-x-n-size-matrix-transpose/"/>
    /// <see cref="https://www.careercup.com/question?id=5667482614366208"/>
    public class RotateMatrix
    {
        ///<summary>
        /// Given an image, how will you turn it by 90 degrees?
        /// First approach: Using temporal matrix.
        /// Usage: MxN & NxN.
        /// </summary>
        /// <param name="input">The input matrix</param>
        /// <returns>A 90 Degrees rotated matrix of the original one.</returns>
        /// <example>
        /// Input
        /// 1  2  3
        /// 4  5  6
        /// 7  8  9
        /// 
        /// Output:
        /// 3  6  9 
        /// 2  5  8 
        /// 1  4  7 
        /// </example>
        /// <see cref="http://www.geeksforgeeks.org/turn-an-image-by-90-degree/"/>
        public static int[,] NinetyDegrees(int[,] input)
        {
            int m = input.GetLength(0);
            int n = input.GetLength(1);

            int[,] result = new int[n, m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[j, m - i - 1] = input[i, j];     //clockwise
                    //result[n - j - 1, i] = input[i, j];   //counter clockwise
                    Display(result);
                }
            }

            return result;
        }

        /// <summary>
        /// Second approach. In-Place using matrix transponse and reversing rows
        /// Usage: NxN  
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <see cref="https://www.careercup.com/question?id=83756"/>
        public static int[,] Rotate90DegreesInPlace(int[,] input)
        {
            //TODO: Expand this approach for MxN
            Display(input);

            int n = input.GetLength(0);
            int m = input.GetLength(1);

            //Transpose the matrix
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    input[j, i] ^= input[i, j];
                    input[i, j] ^= input[j, i];
                    input[j, i] ^= input[i, j];
                    Display(input);
                }
            }

            //Reverse cols
            for (int i = 0; i < n; i++)
            {
                for (int j = 0, k = m - 1; j < m / 2; j++, k--)
                {
                    input[i, j] ^= input[i, k];
                    input[i, k] ^= input[i, j];
                    input[i, j] ^= input[i, k];
                    Display(input);
                }
            }

            return input;
        }

        private static void Display(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Debug.Write(string.Format(" {0} ", input[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }

        private static int[,] Initialize(int[,] input)
        {
            int count = 1;

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    input[i, j] = count++;
                }
                Console.WriteLine();
            }

            return input;
        }
    }
}
