using System;
using System.Diagnostics;

namespace MaximumSizeSquare
{
    public class MaximumSizeSquare
    {
        public static int Print(int[,] matrix)
        {
            var max = -1;
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            var output = new int[m, n];

            // Set first col
            for (int i = 0; i < m; i++)
            {
                output[i, 0] = matrix[i, 0];
            }

            // Set first row
            for (int j = 0; j < n; j++)
            {
                output[0, j] = matrix[0, j];
            }


            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        output[i, j] = 0;
                    }
                    else
                    {
                        // left
                        var x = output[i, j - 1];

                        // top left
                        var y = output[i - 1, j - 1];

                        //up
                        var z = output[i - 1, j];

                        //current cell
                        output[i, j] = Min(x, y, z) + 1;
                    }

                    Show(output);

                    max = Math.Max(max, output[i, j]);
                }
            }

            return max*max;
        }

        private static int Min(int x, int y, int z)
        {
            int min = x;

            if (min > y)
                min = y;
            if (min > z)
                min = z;

            return min;
        }

        private static void Show(int[,] input)
        {
            var m = input.GetLength(0);
            var n = input.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Debug.Write(string.Format(" {0} ", input[i, j]));
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("");
        }
    }
}
