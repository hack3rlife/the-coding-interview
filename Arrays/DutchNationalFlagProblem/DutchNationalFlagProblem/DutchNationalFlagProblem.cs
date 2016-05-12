/*
 * @autor: Some smart guy on the internet
 * @date: 04/28/2015
 * @project: DutchNationalFlagProblem
 * 
 */
namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    /// The Dutch national flag problem (DNF) is a computer science programming problem proposed by Edsger Dijkstra. The flag of the Netherlands consists of three colours: 
    /// red, white and blue. Given balls of these three colours arranged randomly in a line the task is to arrange them such that all balls of the same colour are together and their 
    /// collective colour groups are in the correct order.
    /// The solution to this problem is of interest for designing sorting algorithms. In particular, variants of the quicksort algorithm that must be robust to repeated elements need a 
    /// three-way partitioning function that groups items less than a given key (red), equal to the key (white) and greater than the key (blue). Several solutions exist that have varying 
    /// performance characteristics, tailored to sorting arrays with either small or large numbers of repeated elements.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Dutch_national_flag_problem"/>
    public static class DutchNationalFlagProblem
    {
        /// <summary>
        /// The following code for three-way partitioning assumes zero-based array indexing.
        /// </summary>
        /// <param name="input">The input array</param>
        /// <param name="mid">The pivot or partition element</param>
        /// <returns>A three-way partitioned array</returns>
        public static int[] Sort(int[] input, int mid)
        {
            int i = 0;                      // index to iterate through the array
            int p = 0;                      // current position in the left side (for swaping)
            int q = input.Length - 1;       // current position in the rigth side (for swaping)

            while ( i <= q )
            {
                if (input[i] < mid)
                    Swap(input, i++, p++);                    
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
