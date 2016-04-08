namespace com.hack3rlife.quicksort
{
    public class QuickSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>
        /// <param name="input">Unsorted array of intergers</param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void Sort(int[] input, int left, int right)
        {
            if (left < right)
            {
                var q = Partition(input, left, right);

                Sort(input, left, q - 1);
                Sort(input, q + 1, right);
            }            
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
            var pivot = input[right]; //left + (right-left)/2
            var storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (input[i] < pivot)
                {
                    input = Swap(input, i, storeIndex++);
                }
            }

            input = Swap(input, storeIndex, right);

            return storeIndex;
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        /// <returns></returns>
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
