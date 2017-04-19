namespace com.hack3rlife.dynamicprogramming
{
    public static class WordSearch
    {
        // For searching in all 8 direction
        static int[] adjRow = { -1, -1, -1, 0, 0, 1, 1, 1 };
        static int[] adjCol = { -1, 0, 1, -1, 1, -1, 0, 1 };

        /// <summary>
        /// Given a 2D matrix of char­ac­ters. Check whether the word exist in the matrix or not. If it exists then print its path. All move­ments are allowed (right, left, up, down and diagonally).
        /// 
        /// The 8 directions are, Horizontally Left, Horizontally Right, Vertically Up and 4 Diagonal directions.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <see cref="http://algorithms.tutorialhorizon.com/backtracking-search-a-word-in-a-matrix/"/>
        /// <seealso cref="http://www.geeksforgeeks.org/search-a-word-in-a-2d-grid-of-characters/"/>
        public static bool Search(char[,] matrix, string word)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int[,] result = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int index = 0;

                    var wordExist = SearchHelper(matrix, word, i, j, m, n, result, index);

                    if (wordExist)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool SearchHelper(char[,] matrix, string word, int x, int y, int m, int n, int[,] visited, int index)
        {

            if (matrix[x, y] != word[index] || visited[x, y] != 0)
                return false;

            if (index == word.Length - 1)
                return true;

            visited[x, y] = ++index;

            for (int k = 0; k < 8; k++)
            {
                var currRow = x + adjRow[k];
                var currCol = y + adjCol[k];

                if (IsValidMove(matrix, currRow, currCol, m, n, visited))
                {
                    var result = SearchHelper(matrix, word, currRow, currCol, m, n, visited, index);

                    if (result)
                    {
                        return true;
                    }
                }
            }

            visited[x, y] = 0;
            index--;

            return false;
        }

        private static bool IsValidMove(char[,] input, int currRow, int currCol, int m, int n, int[,] visited)
        {
            if (currRow >= 0 && currRow < m && currCol >= 0 && currCol < n && visited[currRow, currCol] == 0)
                return true;

            return false;
        }
    }
}
