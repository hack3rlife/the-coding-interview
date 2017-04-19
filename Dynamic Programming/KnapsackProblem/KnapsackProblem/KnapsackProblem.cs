using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// The knapsack problem or rucksack problem is a problem in combinatorial optimization: Given a set of items, each with a weight and a value, determine the number of each item to 
    /// include in a collection so that the total weight is less than or equal to a given limit and the total value is as large as possible. It derives its name from the problem faced by 
    /// someone who is constrained by a fixed-size knapsack and must fill it with the most valuable items.
    /// </summary>
    /// <remarks>https://en.wikipedia.org/wiki/Knapsack_problem</remarks>
    public class KnapsackProblem
    {

        /// <summary>
        /// Given weights and values of n items, put these items in a knapsack of capacity W to get the maximum total value in the knapsack
        /// </summary>
        /// <param name="W"></param>
        /// <param name="weights"></param>
        /// <param name="values"></param>
        /// <param name="n"></param>
        /// <returns>The maximum value that can be put in a knapsack of capacity W</returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-10-0-1-knapsack-problem/"/>
        /// <see cref=""/>
        public static int Get(int W, int[] weights, int[] values, int n)
        {
            int[,] result = new int[n + 1, W + 1];

            // Build table int[,] result in bottom up manner
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        result[i, j] = 0;
                    }
                    else if (weights[i - 1] <= j)
                    {
                        result[i, j] = max(values[i - 1] + result[i - 1, j - weights[i - 1]], result[i - 1, j]);
                    }
                    else
                    {
                        result[i, j] = result[i - 1, j];
                    }

                    Print(result);
                }
            }

            return result[n, W];
        }

        private static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        private static void Print(int[,] input)
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
