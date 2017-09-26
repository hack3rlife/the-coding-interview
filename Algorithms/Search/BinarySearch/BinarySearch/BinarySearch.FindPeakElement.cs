namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// A peak element is an element that is greater than its neighbors.
    /// </summary>
    public partial class BinarySearch
    {
        /// <summary>
        /// Given an array of integers. Find a peak element in it. An array element is peak if it is NOT smaller than its neighbors
        /// </summary>
        /// <param name="input">The input array</param>
        /// <returns>The index of the peak element if any; otherwise -1</returns>
        /// <see cref=">https://leetcode.com/problems/find-peak-element/"/>
        /// <seealso cref="http://www.geeksforgeeks.org/find-a-peak-in-a-given-array/"/>
        public static int FindPeakElement( int[] input )
        {
            if (input == null)
                return -1;

            var left = 0;
            var right = input.Length - 1;

            while (left <= right)
            {
                var mid = ( left + right ) / 2;

                // IsPeak current mid?
                if (mid == 0 ||
                    mid == input.Length - 1 ||
                    input[mid - 1] < input[mid] && input[mid + 1] < input[mid])
                {
                    return mid;
                }

                // if middle element is not peak and its left neighbour is greater
                // than it, then left half must have a peak element
                if (input[mid - 1] > input[mid])
                    right = mid - 1;
                // if middle element is not peak and its right neighbour is greater
                // than it, then right half must have a peak element
                else
                    left = mid + 1;
            }

            return -1;
        }
    }
}