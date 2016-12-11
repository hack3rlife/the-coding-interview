using System.Collections.Generic;
using System.Diagnostics;

namespace PrintAllPathsMatrix
{
    public class MatrixPaths
    {
        /// <summary>
        /// Count all the possible paths from top left to bottom right of a mXn matrix with the constraints that from each cell you can either move only to right or down
        /// </summary>
        /// <param name="input">The matrix</param>
        /// <returns>The total number of paths from top left to bottom right </returns>
        /// <see cref="http://www.geeksforgeeks.org/count-possible-paths-top-left-bottom-right-nxm-matrix/"/>
        /// <seealso cref="http://qa.geeksforgeeks.org/3676/number-of-unique-paths"/>
        public static int Count(int[,] input)
        {
            if (input == null || input.Length == 0)
                return 0;

            int m = input.GetLength(0);
            int n = input.GetLength(1);

            int[,] output = new int[m, n];

            // col 1
            for (int i = 0; i < m; i++)
            {
                output[i, 0] = 1;
                Show(output);
            }

            // row 1
            for (int j = 0; j < n; j++)
            {
                output[0, j] = 1;
                Show(output);
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    output[i, j] = output[i - 1, j] + output[i, j - 1];
                    Show(output);
                }
            }

            return output[m - 1, n - 1];
        }

        /// <summary>
        /// Print all the possible paths from top left to bottom right of a mXn matrix with the constraints that from each cell you can either move only to right or down.
        /// </summary>
        /// <param name="input">The matrix</param>
        /// <see cref="http://www.geeksforgeeks.org/print-all-possible-paths-from-top-left-to-bottom-right-of-a-mxn-matrix/"/>
        public static IList<string> Print(int[,] input)
        {
            if (input == null || input.Length == 0)
                return null;

            int m = input.GetLength(0);
            int n = input.GetLength(1);

            IList<string> paths = new List<string>();
            PrintHelper(input, m, n, 0, 0, string.Empty, paths);

            return paths;
        }

        /// <summary>
        /// 
        /// </summary>
        private static void PrintHelper(int[,] input, int m, int n, int i, int j, string path, IList<string> paths)
        {
            // end of row
            if (i == m - 1)
            {
                for (int k = j; k < n; k++)
                {
                    path += string.Format(" {0} ", input[i, k]);
                }

                Debug.WriteLine(path);

                paths.Add(path);
                return;
            }

            //end of col
            if (j == n - 1)
            {
                for (int k = i; k < m; k++)
                {
                    path += string.Format(" {0} ", input[k, j]);
                }

                Debug.WriteLine(path);
                paths.Add(path);
                return;
            }

            path += string.Format(" {0} ", input[i, j], paths);
            PrintHelper(input, m, n, i + 1, j, path, paths);
            PrintHelper(input, m, n, i, j + 1, path, paths);
        }

        /// <summary>
        /// Print the current status of the matrix
        /// </summary>
        /// <param name="input">The matrix</param>
        private static void Show(int[,] input)
        {
            int m = input.GetLength(0);
            int n = input.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Debug.Write(string.Format(" {0} ", input[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("* * * * * * * * * *");
        }

    }
}
