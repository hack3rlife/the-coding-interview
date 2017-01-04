namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// Find the minimum element in a sorted and rotated array
    /// </summary>
    public partial class BinarySearch
    {

        /// <summary>
        /// A sorted array is rotated at some unknown point, find the minimum element in it.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
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
        public static int FindPivot(int[] input, int low, int high)
        {
            // There is no rotation
            if (high < low) return 0;

            if (high == low) return low;

            int mid = low + (high - low) / 2;
            
            if (mid < high && input[mid] > input[mid + 1])
                return mid;

            if (mid > low && input[mid] < input[mid - 1])
                return (mid - 1);

            if (input[low] >= input[mid])
                return FindPivot(input, low, mid - 1);
            else
                return FindPivot(input, mid + 1, high);
        }
    }
}
