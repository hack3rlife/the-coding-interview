namespace com.hack3rlife.algorithms.searching
{
    public static class SquareRoot
    {

        public static int Get(int k)
        {
            var left = 0;
            var right = k;
            var result = 0;

            while (left < right)
            {
                var mid = left + ((right - left) / 2);
                result = mid * mid;

                if (result == k)
                {
                    result = mid;
                }
                else if (result < k)
                {
                    left = mid + 1;
                }
                else //result > k
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}
