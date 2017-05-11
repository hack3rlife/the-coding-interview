using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    public static class JumpGame
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="currIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int MinJumps(int[] input, int currIndex, int length)
        {
            if (currIndex == length)
                return 0;

            if (input[currIndex] == 0)
                return int.MaxValue;

            var min = int.MaxValue;

            for (int i = currIndex + 1; i <= currIndex + input[currIndex] && i <= length; i++)
            {
                int currJumps = MinJumps(input, i, length);

                if (currJumps != int.MaxValue && currJumps + 1 < min)
                    min = currJumps + 1;
            }

            return min;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int MinJumps(int[] input)
        {
            int length = input.Length;

            if (length == 0)
                return 0;

            int[] jumps = new int[length];
            int[] jumpsIndex = new int[length];

            for (int i = 1; i < length; i++)
            {
                jumps[i] = int.MaxValue;

                for (int j = 0; j < i; j++)
                {
                    if (i <= j + input[j])
                    {
                        if (jumps[i] > jumps[j] + 1)
                        {
                            jumps[i] = jumps[j] + 1;
                            jumpsIndex[i] = j;

                            Print(jumps);
                        }
                    }
                }
            }

            return jumps[length - 1];
        }

        /// <summary>
        /// Print the temporal DPT
        /// </summary>
        /// <param name="input">The table</param>
        private static void Print(int[] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                Debug.Write(string.Format("| {0} |", input[i]));
            }

            Debug.WriteLine("");
        }
    }
}
