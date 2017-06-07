using System.Collections.Generic;
using System.Diagnostics;

namespace ShortestPathBinaryMaze
{
    /// <summary>
    /// Shortest path in a Binary Maze
    /// </summary>
    public class ShortestPathBinaryMaze
    {
        static Dictionary<int, Point> adjacentCells = new Dictionary<int, Point>()
        {
            //left
            {0, new Point(-1,0) },
            //up
            {1, new Point(0,-1) },
            //right
            {2, new Point(0,1) },
            //down
            {3, new Point(1,0) },
        };

        /// <summary>
        /// Given a MxN matrix where each element can either be 0 or 1. We need to find the shortest path between a given source cell to a destination cell. The path can only be created 
        /// out of a cell if its value is 1.
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <returns>true if there is a path between a to b; otherwise false</returns>
        /// <see cref="http://www.geeksforgeeks.org/shortest-path-in-a-binary-maze/"/>
        public static int Find(int[,] maze, Point src, Point dest)
        {
            int x = maze.GetLength(0) - 1;
            int y = maze.GetLength(1) - 1;

            var visited = Initialize(x, y);

            visited[src.X, src.Y] = true;

            Queue<Path> q = new Queue<Path>();
            q.Enqueue(new Path(src, 0));

            while (q.Count > 0)
            {
                var curr = q.Dequeue();

                if (curr.Point.X == dest.X && curr.Point.Y == dest.Y)
                    return curr.Distance;

                foreach (var item in adjacentCells)
                {
                    var adjacent = item.Value;
                    var row = curr.Point.X + adjacent.X;
                    var col = curr.Point.Y + adjacent.Y;

                    if (IsValidMove(maze, row, col, x, y, visited))
                    {
                        visited[row, col] = true;
                        q.Enqueue(new Path(new Point(row, col), curr.Distance + 1));

                        Print(visited);
                    }
                }

            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="visited"
        /// <returns></returns>
        private static bool IsValidMove(int[,] maze, int i, int j, int x, int y, bool[,] visited)
        {
            if (i >= 0 && i <= x && j >= 0 && j <= y && maze[i, j] == 1 && visited[i, j] == false)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maze"></param>
        private static void Print(bool[,] maze)
        {
            int x = maze.GetLength(0);
            int y = maze.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Debug.Write(string.Format(" {0} ", maze[i, j]));
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
        private static bool[,] Initialize(int x, int y)
        {
            bool[,] mazeSol = new bool[x + 1, y + 1];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mazeSol[i, j] = false;
                }
            }

            //Print(mazeSol);
            return mazeSol;
        }
    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Path
    {
        public Point Point;
        public int Distance;

        public Path(Point p, int d)
        {
            Point = p;
            Distance = d;
        }
    }
}
