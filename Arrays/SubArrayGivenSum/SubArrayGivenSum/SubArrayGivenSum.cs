using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays
{
    public class SubArrayGivenSum
    {

        public static bool GetSubArray(int[] input, int sum)
        {
            int current_sum = 0;

            int begin = 0;
            int end = 0;

            for (int i = 0; i < input.Length; i++)
            {
                current_sum += input[i];

                if (sum == current_sum)
                {
                    end = i;

                    Console.WriteLine("Sum found between index {0} - {1}", begin, end);
                    return true;
                }

                if (current_sum > sum || current_sum < 0)
                {
                    current_sum = 0;
                    i = begin++;
                    end = i;
                }
            }

            return false;
        }        

    }
}
