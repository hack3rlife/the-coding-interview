
namespace com.hack3rlife.thecodinginterview
{
    /// <summary>
    /// Longest Increasing Subsequence problem is to find a subsequence of a given sequence in which the subsequence's elements are in sorted order, lowest to highest, and in which the subsequence is as long as possible.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Longest_increasing_subsequence"/>
    public static class LongestIncreasingSubsequence
    {
        /// <summary>
        /// The longest Increasing Subsequence (LIS) problem is to find the length of the longest subsequence of a given sequence such that all elements of the subsequence are sorted in increasing order. For example, length of LIS for { 10, 22, 9, 33, 21, 50, 41, 60, 80 } is 6 and LIS is {10, 22, 33, 50, 60, 80}.
        /// </summary>
        /// <example>
        /// 
        /// </example>
        /// <param name="input"></param>
        public static int Get(int[] input)
        {
            int[] result = new int[input.Length];

            Initialize(ref result);

            int i = 1;
            int max = 0;

            while (i < input.Length)
            {
                int j = 0;

                while (j < i)
                {

                    if (input[j] < input[i])
                    {
                        max = Max(result[j] + 1, result[i]);
                        result[i] = max;
                    }

                    j++;
                }

                i++;
            }

            return max;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        private static void Initialize(ref int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = 1;
            }
        }

        private static int[] Sort(int[] input)
        {
            //first loop to iterate through the full array
            for (int i = 0; i < input.Length; i++)
            {
                //second loop to check values from the current position of 'i' vs 'j'
                for (int j = i + 1; j < input.Length; j++)
                {
                    //check the lowest value and swap them: smaller in the left side; bigger in the right side
                    if (input[i] < input[j])
                    {
                        input[i] ^= input[j];
                        input[j] ^= input[i];
                        input[i] ^= input[j];
                    }
                }
            }

            return input;
        }
    }
}
