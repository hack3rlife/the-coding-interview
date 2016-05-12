/*
 * @autor: Some smart guy on internet
 * @date: 04/28/2016
 * @project: SubSetSum
 * 
 */

namespace com.hack3rlife.algorithms
{
    /// <summary>
    /// Given an of unsorted array of integers (you may assume the array may contain +ve, -ve and 0s and a number k where k is smaller than size of array, we need to find the k’th smallest
    /// element in the given array. 
    /// </summary>
    /// <example>input[] = {7, 10, 4, 3, 20, 15} k=3, output = 7</example>
    public class FindKthLargest
    {
        /// <summary>
        /// Finds the kth largest element of a unsorted arrray using QuickSelect algorithm assuming there are no duplicated values. 
        /// </summary>       
        /// <param name="input">The unsorted array</param>
        /// <param name="left">The left sub-array (k-1)</param>
        /// <param name="right">The right sub-array(k+1)</param>
        /// <param name="k">The  kth value</param>
        /// <returns>Returns the k-th smallest element of the array within left..right inclusive</returns>
        public static int Select(int[] input, int left, int right, int k)
        {
            if (left == right)
                return input[left];

            var randomPivotIndex = new System.Random().Next(left, right);

            var privotIndex = Partition(input, left, right, randomPivotIndex);

            if (privotIndex == k)
                return input[k];
            else if (k < privotIndex)
                return Select(input, left, privotIndex - 1, k); //right = pivot - 1;
            else
                return Select(input, privotIndex + 1, right, k); //left = pivot + 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left">The left index</param>
        /// <param name="right">The right index</param>
        /// <param name="pivot">Random pivot between left and rigth</param>
        /// <returns></returns>
        private static int Partition(int[] input, int left, int right, int pivot)
        {
            var pivotValue = input[pivot];  // left + (right - left) / 2;

            Swap(input, pivot, right);

            var storeIndex = left;

            for (int i = left; i < right - 1; i++)
            {
                if (input[i] < pivotValue)
                {
                    Swap(input, i, storeIndex);
                    storeIndex++;
                }
            }

            // Move pivot to its final place
            Swap(input, storeIndex, right);

            return storeIndex;
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        /// <returns></returns>
        private static void Swap(int[] input, int a, int b)
        {
            if (a != b)
            {
                input[a] ^= input[b];
                input[b] ^= input[a];
                input[a] ^= input[b];
            }
        }
    }
}
