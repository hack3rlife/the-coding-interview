namespace com.hack3rlife.algorithms.searching
{
    public partial class BinarySearch
    {
        /// <summary>
        /// You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates in list. One of the integers
        /// is missing in the list. Write an efficient code to find the missing integer.
        /// </summary>
        /// <param name="input">The input array</param>
        /// <returns>The missing number: otherwise -1</returns>
        /// <example>
        /// input: [1, 2, 4, 6, 3, 7, 8]
        /// missing number:5
        /// </example>
        /// <remarks> The input array is sorted in increasing order.</remarks>
        /// <see cref="http://www.geeksforgeeks.org/find-the-missing-number/"/>
        public static int FindMissingElement(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;

            // if there is no missing element
            if (input[right] == input.Length)
                return -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (input[mid] - 1 > mid)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left + 1;
        }
    }
}
