using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.mergesort
{
    public class MergeSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] Sort(int[] input)
        {
            if (input.Length == 1)
                return input;

            int mid = input.Length / 2;

            int[] left = new int[mid];
            for (int i = 0; i < left.Length; i++)
                left[i] = input[i];

            int[] right = new int[input.Length - mid];
            for (int i = 0; i < right.Length; i++)
                right[i] = input[mid++];

            return Merge(Sort(left), Sort(right));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        private static int[] Merge(int[] array1, int[] array2)
        {
            //Temporal array to store the result
            int[] merged = new int[array1.Length + array2.Length];

            int i = 0, j = 0, k = 0;

            while (k < merged.Length)
            {
                //if both arrays are in boundaries
                if (i < array1.Length && j < array2.Length)
                {
                    //check which value is lesser and it's stored it in the current position of k
                    if (array1[i] < array2[j])
                        merged[k++] = array1[i++];
                    else
                        merged[k++] = array2[j++];
                }
                else if (i < array1.Length)     //if just left array1
                    merged[k++] = array1[i++];
                else if (j < array2.Length)     //if just left array1
                    merged[k++] = array2[j++];
            }

            return merged;
        }
    }
}
