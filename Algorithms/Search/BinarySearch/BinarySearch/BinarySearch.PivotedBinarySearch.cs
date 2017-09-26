namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// Search an element in a sorted and rotated array (Find an element in a sorted rotated array without finding pivot)
    /// </summary>
    public static partial class BinarySearch
    {
        /// <summary>
        /// 1) Find middle point mid = (l + h)/2
        /// 2) If key is present at middle point, return mid.
        /// 3) Else If arr[l..mid] is sorted
        ///     a) If key to be searched lies in range from arr[l]
        /// to arr[mid], recur for arr[l..mid].
        /// b) Else recur for arr[mid + 1..r]
        ///     4) Else(arr[mid + 1..r] must be sorted)
        /// a) If key to be searched lies in range from arr[mid + 1]
        ///     to arr[r], recur for arr[mid + 1..r].
        /// b) Else recur for arr[l..mid]
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <![CDATA[
        ///         input: int input[] = {5, 6, 7, 8, 9, 10, 1, 2, 3}, int k = 3;
        ///         output: 8
        /// ]]>
        /// <see cref="http://www.geeksforgeeks.org/search-an-element-in-a-sorted-and-pivoted-array/"/></remarks>
        /// <returns>Returns the position of the number otherwise -1</returns>
        public static int PivotedBinarySearch( int[] input, int k )
        {
            int left = 0;
            int right = input.Length - 1;

            while (left <= right)
            {
                int mid = left + ( right - left ) / 2;

                if (input[mid] == k)
                    return mid;

                if (input[mid] <= input[right])
                {
                    if (k > input[mid] && k <= input[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                else
                {
                    if (input[left] <= k && k < input[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
            }

            return -1;
        }
    }
}