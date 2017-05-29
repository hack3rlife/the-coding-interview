using System.Diagnostics;

namespace CoinChange
{
    /// <summary>
    /// Given a value N, if we want to make change for N cents, and we have infinite supply of each of S = { S1, S2, .. , Sm} valued coins, how many ways 
    /// can we make the change? The order of coins doesn’t matter.
    /// 
    /// </summary>
    /// <example>
    ///  for N = 4 and S = {1,2,3}, there are four solutions: {1,1,1,1},{1,1,2},{2,2},{1,3}. So output should be 4. For N = 10 and S = {2, 5, 3, 6}, there 
    ///  are five solutions: {2,2,2,2,2}, {2,2,3,3}, {2,2,6}, {2,3,5} and {5,5}. So the output should be 5.
    /// </example>
    /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-7-coin-change/"/>
    public class CoinChange
    {
        /// <summary>
        /// Reursive Solution
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="change"></param>
        /// <param name="curr"></param>
        public static int Count(int[] coins, int cents, int curr)
        {
            if (curr >= 0 && curr < coins.Length)
                Debug.WriteLine("Current coin: {0} - cents: {1} curr: {2}", coins[curr], cents, curr);


            if (cents == 0)
            {
                return 1;
            }

            if (cents < 0)
            {
                return 0;
            }

            if (curr < 0 && cents >= 1)
            {
                return 0;
            }

            return Count(coins, cents, curr - 1)
                + Count(coins, cents - coins[curr], curr);
        }


        /// <summary>
        /// Dynamic Programming Solution
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="cents"></param>
        public static int Count(int[] coins, int cents)
        {
            int m = coins.Length;
            int n = cents;

            int[,] result = new int[m, n + 1];

            // first column
            for (int i = 0; i < m; i++)
                result[i, 0] = 1;

            //first row
            for (int j = 0; j <= n; j++)
            {
                if (j % coins[0] == 0)
                    result[0, j] = 1;
                else
                    result[0, j] = 0;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= coins[i - 1])
                    {
                        result[i, j] = result[i - 1, j];
                    }
                    else
                    {
                        result[i, j] = result[i, j - coins[i - 1] - 1] + result[i - 1, j];
                    }

                    Print(result);
                }
            }

            return result[m - 1, n];
        }


        public static int Count2(int[] coins, int cents)
        {
            int length = coins.Length;
            int[] result = new int[cents + 1];

            result[0] = 1;

            for (int i = 0; i < length; i++)
            {
                for (int j = coins[i]; j <= cents; j++)
                {
                    result[j] += result[j - coins[i]];
                    Print(result);
                }
            }

            return result[cents];
        }

        private static void Print(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Debug.Write(string.Format(" {0} ", input[i]));
            }
            Debug.WriteLine("");
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
