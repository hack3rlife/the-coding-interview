using System;
using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// 
    /// </summary>
    public class MinCostPath
    {
        /// <summary>
        /// Given a matrix and a input[i,j], write a function that returns cost of minimum cost path to reach (m, n) from (0, 0). Each cell of the matrix represents a cost to traverse 
        /// through that cell. Total cost of a path to reach input[i,j] is sum of all the costs on that path (including both source and destination). You can only traverse down, right and
        /// diagonally lower cells from a given cell
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-6-min-cost-path/"/>
        public static int Get(int[,] matrix)
        {
            if (matrix == null)
                return 0;

            var result = (int[,])matrix.Clone();

            var xlength = matrix.GetLength(0);
            var ylength = matrix.GetLength(1);

            //fill first cell
            //result[0, 0] = matrix[0, 0];

            // fill first row
            for (int j = 1; j < ylength; j++)
            {
                result[0, j] = matrix[0, j] + result[0, j - 1];
                Print(result);
            }

            //first first column
            for (int i = 1; i < xlength; i++)
            {
                result[i, 0] = matrix[i, 0] + result[i - 1, 0];
                Print(result);
            }

            for (int i = 1; i < xlength; i++)
            {
                for (int j = 1; j < ylength; j++)
                {
                    result[i, j] = matrix[i, j] + Min(result, i, j);
                    Print(result);
                }
            }

            return result[xlength - 1, ylength - 1];
        }

        private static int Min(int[,] input, int i, int j)
        {
            var adjRow = new int[] { 0, -1, -1 };
            var adjCol = new int[] { -1, -1, 0 };

            //left (Remove)
            int a = input[i + adjRow[0], j + adjCol[0]];
            //diag (Replace)
            int b = input[i + adjRow[1], j + adjCol[1]];
            //top (Insert)
            int c = input[i + adjRow[2], j + adjCol[2]];

            int smallest = Math.Min(Math.Min(a, b), c);

            return smallest;
        }

        /// <summary>
        /// Print the temporal DPT
        /// </summary>
        /// <param name="matrix">The table</param>
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Debug.Write(string.Format("{0} ", matrix[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }
    }
}
