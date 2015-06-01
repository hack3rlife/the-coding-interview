using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays
{
    public class PythagoreanTriplet
    {
       public static bool HasTriplet(int[] input)
        {
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    for (int k = j + 1; k < length; k++)
                    {
                        int x = input[i] * input[i], y = input[j] * input[j], z = input[k] * input[k];

                        if (x == y + z || y == x + z || z == x + y)
                            return true;
                    }
                }
            }

            return false;
        }

       private bool IsTriplet(int a, int b, int c)
       {
           bool first, second, third;

           first = ((a + b) > c);
           second = ((a + c) > b);
           third = ((c + b) > a);

           return (first && second && third);
       }
    }
}