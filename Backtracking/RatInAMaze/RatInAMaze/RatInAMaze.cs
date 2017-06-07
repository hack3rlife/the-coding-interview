using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// 
    /// </summary>
    public static class RatInAMaze
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maze"></param>
        /// <returns>true if there is a path to the exit; otherwise false</returns>
        /// <see cref="http://www.geeksforgeeks.org/backttracking-set-2-rat-in-a-maze/"/>
        public static bool Find(int[,] maze)
        {
            int x = maze.GetLength(0) - 1;
            int y = maze.GetLength(1) - 1;

            var res = Initialize(x, y);

            return FindHelper(maze, 0, 0, x, y, res);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        private static bool FindHelper(int[,] maze, int i, int j, int x, int y, int[,] res)
        {
            // Print current status of the solution board
            Print(res);

            // exit 
            if (i == x && j == y)
            {
                res[i, j] = 1;
                Print(res);
                return true;
            }

            // Check if the current position (maze[i,j]) is a valid move
            if (IsValidMove(maze, i, j, x, y))
            {
                res[i, j] = 1;

                // move right
                if (FindHelper(maze, i, j + 1, x, y, res) == true)
                    return true;

                // move down
                if (FindHelper(maze, i + 1, j, x, y, res) == true)
                    return true;

                res[i, j] = 0;

                return false;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static bool IsValidMove(int[,] maze, int i, int j, int x, int y)
        {
            if (i >= 0 && i <= x && j >= 0 && j <= y && maze[i, j] == 1)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        private static void Print(int[,] board)
        {
            int x = board.GetLength(0);
            int y = board.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Debug.Write(string.Format(" {0} ", board[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int[,] Initialize(int x, int y)
        {
            int[,] mazeSol = new int[x + 1, y + 1];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mazeSol[i, j] = 0;
                }
            }

            return mazeSol;
        }
    }
}
