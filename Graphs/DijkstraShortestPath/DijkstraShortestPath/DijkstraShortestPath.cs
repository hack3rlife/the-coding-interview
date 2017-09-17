using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraShortestPath
{
    /// <summary>
    /// Dijkstra's algorithm is an algorithm for finding the shortest paths between nodes in a graph, which may represent, for example, road networks. It was conceived by 
    /// computer scientist Edsger W. Dijkstra in 1956 and published three years later.
    /// 
    /// The algorithm exists in many variants; Dijkstra's original variant found the shortest path between two nodes, but a more common variant fixes a single node as the 
    /// "source" node and finds shortest paths from the source to all other nodes in the graph, producing a shortest-path tree.
    /// 
    /// For a given source node in the graph, the algorithm finds the shortest path between that node and every other. It can also be used for finding the shortest paths from 
    /// a single node to a single destination node by stopping the algorithm once the shortest path to the destination node has been determined. For example, if the nodes of the graph represent cities and edge path costs represent driving distances between pairs of cities connected by a direct road, Dijkstra's algorithm can be used to find the shortest route between one city and all other cities.
    /// </summary>
    /// <see cref="http://www.geeksforgeeks.org/greedy-algorithms-set-6-dijkstras-shortest-path-algorithm/"/>
    public static class DijkstraShortestPath
    {
        public static void Find(int[,] input, int src)
        {
            var length = input.GetLength(0);
            var output = Enumerable.Repeat ( int.MaxValue, length ).ToArray ();
            var visited = new bool[length];

            output[src] = 0;

            for (int k = 0; k < length; k++)
            {
                var i = MinDistance(output, visited);

                visited[i] = true;

                for (int j = 0; j < length; j++)
                {
                    if(visited[j] == false && 
                       input[i,j] != 0 &&
                        output[i] != int.MaxValue && 
                        output[i] + input[i,j] < output[j])
                    {
                        output[j] = output[i] + input[i, j];
                        Print(output);
                        Print ( visited );
                    }
                }
            }
        }

        private static int MinDistance(int[] output, bool[] visited)
        {
            int min = int.MaxValue;
            int min_index = -1;
            int length = output.Length;

            for (int i = 0; i < length; i++)
            {
                if(output[i] < min && visited[i] == false)
                {
                    min = output[i];
                    min_index = i;
                }
            }

            return min_index; 
        }

        private static void Print(int[] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                if (input[i] == int.MaxValue)
                    Debug.Write(" - ");
                else
                    Debug.Write(string.Format(" {0} ", input[i]));
            }

            Debug.WriteLine("");
        }

        private static void Print( bool[] input )
        {
            for (int i = 0; i < input.GetLength ( 0 ); i++)
            {
                Debug.Write ( string.Format ( " {0} ", input[i] ) );
            }

            Debug.WriteLine ( "" );
        }
    }
}
