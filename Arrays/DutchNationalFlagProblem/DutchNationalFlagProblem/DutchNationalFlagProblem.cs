using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.dnf
{
    public class DutchNationalFlagProblem
    {
        public int[] DNFSort(int[] input, int mid)
        {
            int i = 0;
            int p = 0;
            int q = input.Length - 1;

            while ( i <= q )
            {
                if (input[i] < mid)
                {
                    Swap(input, i++, p++);                    
                }
                else if (input[i] > mid)
                    Swap(input, i, q--);
                else
                    i++;
            }

            return input;
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
