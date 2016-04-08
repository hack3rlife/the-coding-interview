namespace com.hack3rlife.quickselect
{
    /// <summary>
    /// Implements Quick Select algorithm 
    /// </summary>
    public class QuickSelect
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Select(int[] input, int left, int right, int k)
        {
            if (left == right)
                return input[left-1];

            var privotIndex = Partition(input, left, right);

            if (privotIndex == k)
                return input[privotIndex-1];
            else if (k < privotIndex)
                return Select(input, left, privotIndex - 1, k); //right = pivot - 1;
            else
                return Select(input, privotIndex + 1, right, k); //left = pivot + 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static int Partition(int[] input, int left, int right)
        {
            var pivotValue = input[right]; ; // left + (right - left) / 2;
            var storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (input[i] < pivotValue)
                {
                    input = Swap(input, i, storeIndex++);
                }
            }

            input = Swap(input, storeIndex, right);

            return storeIndex;
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
