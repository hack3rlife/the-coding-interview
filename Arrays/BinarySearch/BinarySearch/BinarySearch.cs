using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays
{
    public class BinarySearch
    {
        public static int? StandardBinarySearchIterative(int[] input, int key, int min, int max)
        {
            while (max > min)
            {
                int mid = min + ((max - min) / 2);

                if (input[mid] < key)
                {
                    min = mid + 1;
                }
                else if (input[mid] > key)
                    max = mid - 1;
                else
                    return mid;
            }

            return null;
        }

        public static int? StandardBinarySearchRecursive(int[] input, int key, int min, int max)
        {
            if (max < min)
                return null;

            int mid = min + ((max - min) / 2);

            if (key == input[mid])
                return mid;
            if (key > input[mid])
                return StandardBinarySearchRecursive(input, key, (mid + 1), max);
            else
                return StandardBinarySearchRecursive(input, key, min, (mid - 1));
        }

        public static int? PivotedBinarySearch(int[] input, int key)
        {
            int pivot = FindPivot(input, 0, input.Length - 1);

            // No rotation, we use standard binary search
            if (pivot == -1)
                return StandardBinarySearchRecursive(input, key, 0, input.Length - 1);

            // If we found a pivot, then first compare with pivot and then
            // search in two subarrays around pivot
            if (input[pivot] == key)
                return pivot;

            if (input[0] <= key)
                return StandardBinarySearchRecursive(input, key, 0, pivot - 1);
            else
                return StandardBinarySearchRecursive(input, key, pivot + 1, input.Length - 1);
        }

        private static int FindPivot(int[] input, int low, int high)
        {
            if (high < low) return -1;

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
