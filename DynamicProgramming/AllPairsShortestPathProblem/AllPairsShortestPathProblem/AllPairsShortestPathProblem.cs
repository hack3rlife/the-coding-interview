using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// In computer science, the Floyd–Warshall algorithm is an algorithm for finding shortest paths in a weighted graph with positive or negative edge weights (but with no 
    /// negative cycles).  A single execution of the algorithm will find the lengths (summed weights) of the shortest paths between all pairs of vertices. Although it does not 
    /// return details of the paths themselves, it is possible to reconstruct the paths with simple modifications to the algorithm. 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Floyd%E2%80%93Warshall_algorithm"/>
    public static class AllPairsShortestPathProblem
    {
        public static void FloydWarshall(int[,] input)
        {
            int[,] output = (int[,])input.Clone();
            Print(output);

            int length = input.GetLength(0); 
            for (int k = 0; k < length; k++)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (output[i, k] != int.MaxValue && output[k, j] != int.MaxValue && output[i, k] + output[k, j] < output[i, j])
                        {
                            output[i, j] = output[i, k] + output[k, j];
                            Print(output);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Print the temporal DPT
        /// </summary>
        /// <param name="matrix">The table</param>
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == int.MaxValue)
                        Debug.Write(" - ");
                    else
                        Debug.Write(string.Format(" {0} ", matrix[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }
    }
}
