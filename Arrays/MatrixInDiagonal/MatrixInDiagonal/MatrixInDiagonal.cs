using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// How can I print all elements of a matrix in diagonal order?
    /// </summary>
    public class MatrixInDiagonal
    {
        /// <summary>
        /// Given a matrix of MxN, print the elements of the matrix in diagonal order
        /// </summary>
        /// <param name="input"></param>
        /// <see cref="https://www.quora.com/How-can-I-print-all-elements-of-a-matrix-in-diagonal-order"/>
        /// <example>
        /// Matrix:
        /// 1 2 3
        /// 4 5 6
        /// 7 8 9
        ///
        /// Output:
        /// 1
        /// 4 2
        /// 7 5 3
        /// 8 6
        /// 9
        /// </example>
        /// <returns>The diagonal order of the input matrix</returns>
        public static int[,] Print( int[,] input )
        {
            if (input == null)
                return null;

            var rowCount = input.GetLength (0);
            var colCount = input.GetLength (1);

            var output = new int[rowCount + colCount - 1, rowCount];
            var x = 0;
            var y = 0;

            // 1. Print row diagonals
            for (int i = 0 ; i < rowCount ; i++)
            {
                var row = i;
                var col = 0;

                while (row >= 0 && col < colCount)
                {
                    Debug.Write ($" {input[row, col]}");
                    output[x, y] = input[row, col];

                    row--;
                    col++;
                    y++;
                }

                x++;
                y = 0;
                Debug.WriteLine ("");
            }

            // 2. Print col diagonals
            for (int j = 1 ; j < colCount ; j++)
            {
                var row = rowCount - 1;
                var col = j;

                while (row >= 0 && col < colCount)
                {
                    Debug.Write ($" {input[row, col]}");
                    output[x, y] = input[row, col];

                    row--;
                    col++;
                    y++;
                }

                x++;
                y = 0;
                Debug.WriteLine ("");
            }

            return output;
        }
    }
}