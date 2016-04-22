namespace com.hack3rlife.dnf
{
    /// <summary>
    /// 
    /// </summary>
    public class DutchNationalFlagProblem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="mid"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        /// <returns></returns>
        private static void Swap(int[] input, int a, int b)
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
