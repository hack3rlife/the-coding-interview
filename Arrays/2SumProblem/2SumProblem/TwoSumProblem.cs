using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays
{
    public class TwoSumProblem
    {
        /// <summary>
        /// Given an unsorted array of integers, return indices of the two numbers such that they add up to a specific target.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] TwoSumUnsortedArray( int[] input, int k )
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var key = k - input[i];
                if (dict.TryGetValue(key, out int j))
                {
                    return new int[] { j, i };
                }

                if (!dict.ContainsKey(input[i]))
                    dict.Add(input[i], i);
            }

            return null;
        }

        /// <summary>
        /// Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumSortedArray( int[] input, int k )
        {
            var i = 0;
            var j = input.Length - 1;

            while (i < j)
            {
                var currSum = input[i] + input[j];

                if (currSum == k)
                    return new int[] { i + 1, j + 1 };
                else if (currSum < k)
                    i++;
                else
                    j--;
            }

            return null;
        }
    }
}