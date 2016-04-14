namespace com.hack3rlife.insertionsort
{
    /// <summary>
    /// Insertion sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time. 
    /// More efficient in practice than most other simple quadratic algorithms such as selection sort or bubble sort.
    /// It is simple to implement, stable and in-place algorithm. Also, it could sort items as it receives it.
    /// </summary>
    /// <remarks>
    /// Worst case: О(n2)
    /// Average case: О(n2)
    /// Best Case: O(n)
    /// Space Required: O(1)
    /// </remarks>
    /// <remarks>https://en.wikipedia.org/wiki/Insertion_sort</remarks>
    public class InsertionSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>        
        /// <param name="input">Unsorted array of intergers</param>
        /// <![CDATA[input = { 3, 7, 4, 9, 5, 2, 6, 1 } - output = { 1, 2, 3, 4, 6, 7, 9 };]]>
        /// <returns>A sorted array of integeres</returns>
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int j = i;
                while (j > 0 && input[j - 1] > input[j])
                {
                    Swap(input, j, j - 1);
                    j--;
                }
            }
            return input;
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        /// <returns></returns>
        private void Swap(int[] input, int a, int b)
        {
            if (a != b)
            {
                input[a] ^= input[b];
                input[b] ^= input[a];
                input[a] ^= input[b];
            }
        }
    }
}