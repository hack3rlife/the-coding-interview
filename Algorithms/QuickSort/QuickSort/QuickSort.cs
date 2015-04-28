using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.quicksort
{
    public class QuickSort
    {
        public static void Sort(int[] input, int left, int right)
        {
            if (left < right)
            {
                var q = Partition(input, left, right);

                Sort(input, left, q - 1);
                Sort(input, q + 1, right);
            }            
        }

        private static int Partition(int[] input, int left, int right)
        {
            var pivot = input[right]; //left + (right-left)/2
            var storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (input[i] < pivot)
                {
                    input = Swap(input, i, storeIndex++);
                }
            }

            input = Swap(input, storeIndex, right);

            return storeIndex;
        }

        private static int[] Swap(int[] input, int a, int b)
        {
            if (a != b)
            {
                input[a] ^= input[b];
                input[b] ^= input[a];
                input[a] ^= input[b];
            }

            return input;
        }
    }
}
