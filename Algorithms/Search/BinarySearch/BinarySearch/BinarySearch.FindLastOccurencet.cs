namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    ///
    /// </summary>
    public static partial class BinarySearch
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindLastOccurrence( int[] input, int k )
        {
            var left = 0;
            var right = input.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var mid = left + ( ( right - left ) / 2 );

                if (input[mid] == k)
                {
                    result = mid;
                    left = mid + 1;
                }
                else if (input[mid] > k)
                {
                    right = mid - 1;
                }
                else //input[mid] < k
                {
                    left = mid + 1;
                }
            }

            return result;
        }
    }
}