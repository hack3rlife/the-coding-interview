namespace com.hack3rlife.numbers
{
    /// <summary>
    /// Find the largest pair sum in an unsorted array
    /// </summary>
    public class LargestPairSum
    {
        /// <summary>
        /// Given an unsorted of distinct integers, find the largest pair sum in it.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The largest pair sum</returns>
        /// <example>
        /// The largest pair sum in {12, 34, 10, 6, 40} is 74.
        /// </example>
        /// <see cref="http://www.geeksforgeeks.org/find-the-largest-pair-sum-in-an-unsorted-array/"/>
        public static int Find( int[] input )
        {
            int first = input[0];
            int second = input[1];

            if (second > first)
            {
                first ^= second;
                second ^= first;
                first ^= second;
            }

            for (int i = 2; i < input.Length; i++)
            {
                if (input[i] > first)
                {
                    second = first;
                    first = input[i];
                }
                else if (input[i] > second && input[i] <= first)
                {
                    second = input[i];
                }
            }

            return first + second;
        }
    }
}