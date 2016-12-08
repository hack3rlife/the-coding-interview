using System;

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

            //fill firs cell
            result[0, 0] = matrix[0, 0];

            // fill first row
            for (int j = 1; j < ylength; j++)
            {
                result[0, j] = matrix[0, j] + result[0, j - 1];
            }

            //first first column
            for (int i = 1; i < xlength; i++)
            {
                result[i, 0] = matrix[i, 0] + result[i - 1, 0];
            }

            for (int i = 1; i < xlength; i++)
            {
                for (int j = 1; j < ylength; j++)
                {
                    result[i, j] = matrix[i, j] + Math.Min(result[i, j - 1], result[i - 1, j]);
                }
            }

            return result[xlength - 1, ylength - 1];
        }
    }
}
