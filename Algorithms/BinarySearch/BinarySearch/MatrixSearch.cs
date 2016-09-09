namespace com.hack3rlife.algorithms.searching
{
    public class MatrixSearch
    {
        public static bool Get(int[,] input, int k)
        {
            var row = 0;
            var col = input.GetLength(1) - 1;

            while (row < input.GetLength(0) && col >= 0)
            {
                if (input[row, col] == k)
                {
                    return true;
                }
                else if (input[row, col] < k)
                {
                    row++;
                }
                else  //input[row, col] > k
                {
                    col--;
                }

            }

            return false;
        }
    }
}
