using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays
{
    public class LargestSumSubArray
    {
        public static int GetLargestSum(int[] input)
        {
            int max_sum = 0;
            int current_sum = 0;

            int begin = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                current_sum += input[i];

                if (current_sum < 0)
                {
                    current_sum = 0;
                    begin = i + 1;
                    end = begin;
                }

                if (max_sum < current_sum)
                {
                    max_sum = current_sum;
                    end = i;

                    Console.WriteLine("Current Sum found between index {0} - {1}", begin, end);

                }
            }

            Console.WriteLine("Max Sum: {0} found between index {1} - {2}", max_sum, begin, end);

            return max_sum;
        }

    }
}
