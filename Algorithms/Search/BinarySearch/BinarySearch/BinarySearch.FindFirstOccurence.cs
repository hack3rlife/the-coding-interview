using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class BinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <![CDATA[
        ///         Input: arr[] = {1, 1, 2, 2, 2, 2, 3},   x = 2
        ///         Output: 2
        /// ]]>
        /// 
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindFirstOccurrence(int[] input, int k)
        {
            var left = 0;
            var right = input.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var mid = left + ((right - left) / 2);

                if (input[mid] == k)
                {
                    result = mid;
                    right = mid - 1;
                }
                else if (input[mid] > k)
                {
                    right = mid - 1;
                }
                else //input[mid] < k
                {
                    left = mid + 1;
                }

            }

            return result;
        }
    }
}
