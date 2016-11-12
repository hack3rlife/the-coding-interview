namespace com.hack3rlife.algorithms.searching
{
    public partial class BinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
		public static int FindPeakElement(int[] input)
        {
            if (input == null)
                return -1;

            var left = 0;
            var right = input.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                // IsPeak current mid?
                if (mid == 0 ||
                    mid == input.Length - 1 ||
                    input[mid - 1] < input[mid] && input[mid + 1] < input[mid])
                {
                    return mid;
                }

                if (input[mid - 1] > input[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
