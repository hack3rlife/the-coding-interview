using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.bubblesort
{
    public class BubbleSort
    {
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        input[i] ^= input[j];
                        input[j] ^= input[i];
                        input[i] ^= input[j];
                    }
                }
            }

            return input;
        }
    }
}
