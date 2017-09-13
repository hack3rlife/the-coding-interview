/*
 * @autor: Elementes of Programming Interview
 * @date: 04/18/2016
 * @project: Count Bits in a integer
 * 
 */

namespace com.hack3rlife.bitmanipulation
{
    /// <summary>
    /// Implements counting ones in a number
    /// </summary>
    public static class CountBits
    {
        /// <summary>
        /// Counts the number of 1s in a number
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Count(int x)
        {
            int numBits = 0;

            while (x > 0)
            {
                numBits += x & 1;

                x >>= 1;
            }

            return numBits;
        }
    }
}
