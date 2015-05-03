using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays
{
    public static class SubSetSum
    {
        //using dynamic programming
        public static bool HasSubSetSum(int[] input, int n, int sum)
        {
            if (sum == 0)
                return true;
            if (n == 0 && sum != 0)
                return false;

            if (input[n - 1] > sum)
                return HasSubSetSum(input, n - 1, sum);

            return HasSubSetSum(input, n - 1, sum) || HasSubSetSum(input, n - 1, sum - input[n - 1]);
        }

    }
}
