namespace com.hack3rlife.algorithms.searching
{
    public static class BinarySearchExtension
    {
        public static int SearchFirstOccurenceOf(int[] input, int k)
        {
            var left = 0;
            var right = input.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var mid = left - ((right - left) / 2);

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
