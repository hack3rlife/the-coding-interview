namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// Find the minimum element in a sorted and rotated array (Find Pivot)
    /// </summary>
    public partial class BinarySearch
    {
        public static int FindMinimumElement( int[] input, int low, int high )
        {
            // There is no rotation
            if (high < low)
                return 0;

            if (high == low)
                return low;

            int mid = low + ( high - low ) / 2;

            if (mid < high && input[mid] > input[mid + 1])
                return mid + 1;

            if (mid > low && input[mid] < input[mid - 1])
                return mid;

            if (input[low] >= input[mid])
                return FindMinimumElement (input, low, mid - 1);
            else
                return FindMinimumElement (input, mid + 1, high);
        }

        /// <summary>
        /// A sorted array is rotated at some unknown point, find the minimum element in it.
        /// </summary>
        /// <param name="input"></param>
        /// <![CDATA[
        /// Input: {5, 6, 1, 2, 3, 4}
        /// Output: 1
        ///
        /// Input: {1, 2, 3, 4}
        /// Output: 1
        ///
        /// Input: {2, 1}
        /// Output: 1
        /// ]]>
        /// <see cref="http://www.geeksforgeeks.org/find-minimum-element-in-a-sorted-and-rotated-array/"/>
        /// <remarks>The minimum element is the only element whose previous element is greater than it. If there is no such element, then there is no
        /// rotation and first element is the minimum element. Therefore, we do binary search for an element which is smaller than the previous element.
        /// </remarks>
        /// <returns></returns>
        public static int FindMinimumElement( int[] input )
        {
            int left = 0;
            int right = input.Length - 1;

            //if the array is not rotated or is only one element
            if (input[left] < input[right] || input.Length == 1)
                return 0;

            while (left <= right)
            {
                int mid = left + ( right - left ) / 2;

                if (input[mid] > input[mid + 1])
                    return mid + 1;
                else if (input[left] <= input[mid])
                    left = mid + 1;
                else // if (input[mid] > input[right])
                    right = mid - 1;
            }

            return -1;
        }
    }
}