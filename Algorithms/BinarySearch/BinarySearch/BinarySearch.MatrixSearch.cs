namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class BinarySearch
    {
        /// <summary>
        /// Given an n x n matrix, where every row and column is sorted in increasing order. Given a number x, how to decide whether this x is in the matrix. 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <see cref="http://www.geeksforgeeks.org/search-in-row-wise-and-column-wise-sorted-matrix/"/>
        /// <returns></returns>
        public static bool MatrixSearch(int[,] input, int k)
        {
            var row = 0;
            var col = input.GetLength(1) - 1;

            while (row < input.GetLength(0) && col >= 0)
            {
                if (input[row, col] == k)
                    return true;
                else if (input[row, col] < k)
                    row++;
                else  //input[row, col] > k
                    col--;
            }

            return false;
        }
    }
}
