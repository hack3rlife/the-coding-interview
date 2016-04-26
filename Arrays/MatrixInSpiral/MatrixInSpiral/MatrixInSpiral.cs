/*
 * @autor: Some smart guy on internet
 * @date: 04/24/2016
 * @project: SubSetSum
 * 
 */

using System;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// 
    /// </summary>
    public static class MatrixInSpiral
    {
        /// <summary>
        /// Given a 2D array, print it in spiral form.
        /// </summary>
        /// <param name="input"></param>
        /// <see cref="http://www.geeksforgeeks.org/print-a-given-matrix-in-spiral-form/"/>
        public static void PrintSpiral(int[,] input)
        {
            int length = input.GetLength(0) - 1;

            //iterate over the matrix length/2
            for (int i = 0; i < input.GetLength(0) / 2; i++)
            {
                int k = length - i; //current bound

                //row -> left to rigth
                for (int j = i; j < k; j++)
                    Console.Write("{0} ", input[i, j]);

                //right column -> downwards
                for (int j = i; j < k; j++)
                    Console.Write("{0} ", input[j, k]);

                //row -> right to left 
                for (int j = k; j > i; j--)
                    Console.Write("{0} ", input[k, j]);

                //left column -> bottom up
                for (int j = k; j > i; j--)
                    Console.Write("{0} ", input[j, i]);
            }

            if (input.GetLength(0) % 2 == 1)
                Console.Write(input[input.GetLength(0) / 2, input.GetLength(0) / 2]);
        }
    }
}
