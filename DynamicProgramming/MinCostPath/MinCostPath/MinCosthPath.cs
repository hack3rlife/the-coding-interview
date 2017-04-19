using System;
using System.Diagnostics;

namespace MinCostPath
{
    public class MinCosthPath
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
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
                    result[i, j] = matrix[i, j] + Math.Min(result[i, j - 1], result[i - 1, j]);
                    Print(result);
                }
            }

            return result[xlength - 1, ylength - 1];
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
