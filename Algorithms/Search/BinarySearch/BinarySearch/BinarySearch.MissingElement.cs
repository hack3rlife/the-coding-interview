using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.algorithms.searching
{
    public partial class BinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <remarks>http://java67.blogspot.com/2014/12/how-to-find-missing-number-in-sorted.html</remarks>
        public static int FindMissingElement(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left <= right)
            {
                int middle = (right + left) >> 1;

                if (input[middle] != middle)
                {
                    if (middle == 0 || input[middle - 1] == middle - 1)
                    {
                        return middle;
                    }

                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}
