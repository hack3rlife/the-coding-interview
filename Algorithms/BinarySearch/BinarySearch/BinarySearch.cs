/*
 * @autor: Some smart guy on internet
 * @date: 27/05/2015
 * @project: ArrayToBinarySearchTree
 * 
 */

namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    ///  BinarySearch is a search algorithm that finds the position of a target value, whether alone or part of a record, within a sorted array. 
    ///  It works by comparing the target value to the middle element of the array; if they are not equal, the lower or upper half of the array is 
    ///  eliminated depending on the result and the search is repeated until the position of the target value is found.
    ///  Binary search only works on sorted arrays. 
    /// </summary>
    /// <remarks>
    /// Worst case: О(log n)
    /// Average case: О(log n)
    /// Best Case: O(1)
    /// Space Required: O(n)
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Binary_search_algorithm"/>
    public class BinarySearch
    {
        /// <summary>
        /// A binary search begins by comparing the middle element of the array with the target value. If the target value matches the middle element, its position in the array is returned. 
        /// If the target value is less or more than the middle element, the search continues the lower or upper half of the array respectively with a new middle element, eliminating the 
        /// other half from consideration.
        /// </summary>
        /// <param name="input">The sorted array</param>
        /// <param name="key">The element to be searched</param>
        /// <param name="min">Left index</param>
        /// <param name="max">Right index</param>
        /// <example></example>
        /// <returns>Returns the index of the key value: otherwise null</returns>
        public static int? IterativeSearch(int[] input, int key, int min, int max)
        {
            while (max >= min)
            {
                //find mid index
                int mid = min + ((max - min) / 2);
                
                if (input[mid] < key)       //if the value input[mid] is less than key, go to the right side of the array 
                    min = mid + 1;                
                else if (input[mid] > key)  //else if input[mid] is more than key, then go to the left side of the array
                    max = mid - 1;
                else
                    return mid;             //else we found the value
            }

            return null;
        }

        /// <summary>
        /// Recurse method for Binary Search
        /// </summary>
        /// <param name="input">The input array</param>
        /// <param name="key">The value we are looking for</param>
        /// <param name="min">The left side of th array (A.K.A. values less than key)</param>
        /// <param name="max">The rigth side of the array (A.K.A. values more than key)</param>
        /// <returns></returns>
        public static int? RecursiveSearch(int[] input, int key, int min, int max)
        {
            if (max < min)
                return null;

            int mid = min + ((max - min) / 2);

            if (key == input[mid])
                return mid;

            if (key > input[mid])
                return RecursiveSearch(input, key, (mid + 1), max);
            else
                return RecursiveSearch(input, key, min, (mid - 1));
        }

        //public static int? PivotedBinarySearch(int[] input, int key)
        //{
        //    int pivot = FindPivot(input, 0, input.Length - 1);

        //    // No rotation, we use standard binary search
        //    if (pivot == -1)
        //        return StandardBinarySearchRecursive(input, key, 0, input.Length - 1);

        //    // If we found a pivot, then first compare with pivot and then
        //    // search in two subarrays around pivot
        //    if (input[pivot] == key)
        //        return pivot;

        //    if (input[0] <= key)
        //        return StandardBinarySearchRecursive(input, key, 0, pivot - 1);
        //    else
        //        return StandardBinarySearchRecursive(input, key, pivot + 1, input.Length - 1);
        //}

        //private static int FindPivot(int[] input, int low, int high)
        //{
        //    if (high < low) return -1;

        //    if (high == low) return low;

        //    int mid = low + (high - low) / 2;

        //    if (mid < high && input[mid] > input[mid + 1])
        //        return mid;

        //    if (mid > low && input[mid] < input[mid - 1])
        //        return (mid - 1);

        //    if (input[low] >= input[mid])
        //        return FindPivot(input, low, mid - 1);
        //    else
        //        return FindPivot(input, mid + 1, high);
        //}
    }
}
