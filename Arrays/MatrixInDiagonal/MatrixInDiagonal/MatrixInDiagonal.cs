using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Given a matrix of MxN, print the elements of the matrix in diagonal order
    /// </summary>
    public class MatrixInDiagonal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public static void Print(int[,] input)
        {
            if (input == null)
                return;

            var rowCount = input.GetLength(0);
            var colCount = input.GetLength(1);

            var length = rowCount + colCount - 1;

            // 1. Print row diagonals 
            for (int i = 0; i < rowCount; i++)
            {
                var row = i;
                var col = 0;

                while (row >= 0 && col < colCount)
                {
                    Debug.Write(string.Format(" {0} ", input[row, col]));

                    row--;
                    col++;
                }

                Debug.WriteLine("");
            }

            // 2. Print col diagonals
            for (int j = 1; j < colCount; j++)
            {
                var row = rowCount - 1;
                var col = j;

                while (row >= 0 && col < colCount)
                {
                    Debug.Write(string.Format(" {0} ", input[row, col]));

                    row--;
                    col++;
                }

                Debug.WriteLine("");
            }
        }
    }
}
