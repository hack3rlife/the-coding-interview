using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// Find the number of islands
    /// </summary>
    public class NumberOfIslands
    {
        /// <summary>
        /// Given a boolean 2D matrix, find the number of islands. A group of connected 1s forms an island. For example, the below matrix contains 5 islands
        /// </summary>
        /// <![CDATA[
        /// Input : mat[,] = {{1, 1, 0, 0, 0},
        ///                    {0, 1, 0, 0, 1},
        ///                    {1, 0, 0, 1, 1},
        ///                    {0, 0, 0, 0, 0},
        ///                    {1, 0, 1, 0, 1} 
        /// Output : 5
        /// ]]>
        /// <param name="input"></param>
        /// <returns>The number of islands</returns>
        public static int Find(int[,] input)
        {
            var count = 0;

            if (input == null || input.Length == 0)
                return count;

            int m = input.GetLength(0);
            int n = input.GetLength(1);

            // keep track of visited cells
            var visited = new bool[m, n];

            var adjRow = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            var adjCol = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (input[i, j] == 1 && visited[i, j] == false)
                    {
                        visited[i, j] = true;

                        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
                        q.Enqueue(new Tuple<int, int>(i, j));

                        while (q.Count > 0)
                        {
                            var currPos = q.Dequeue();

                            for (int k = 0; k < 8; k++)
                            {
                                var currRow = currPos.Item1 + adjRow[k];
                                var currCol = currPos.Item2 + adjCol[k];

                                if (IsValidMove(input, currRow, currCol, m, n, visited))
                                {
                                    visited[currRow, currCol] = true;
                                    q.Enqueue(new Tuple<int, int>(currRow, currCol));

                                    Print(visited);
                                }
                            }
                        }

                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="currRow"></param>
        /// <param name="currCol"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="visited"></param>
        /// <returns></returns>
        private static bool IsValidMove(int[,] input, int currRow, int currCol, int m, int n, bool[,] visited)
        {
            if (currRow >= 0 && currRow < m && currCol >= 0 && currCol < n && input[currRow, currCol] == 1 && visited[currRow, currCol] == false)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        private static void Print(bool[,] input)
        {
            int x = input.GetLength(0);
            int y = input.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Debug.Write(string.Format(" {0} ", input[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }
    }
}
