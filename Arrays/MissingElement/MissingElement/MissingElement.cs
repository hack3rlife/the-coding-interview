/*
 * @autor: Some smart guy on internet
 * @date: 04/28/2015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Find the Missing Number
    /// </summary>
    public class MissingElement
    {
        /// <summary>
        /// You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates in list. One of the integers is missing in the list. Write an 
        /// efficient code to find the missing integer.
        /// </summary>
        /// <param name="input">The input array</param>
        /// <returns>The issing number</returns>
        /// <example>
        /// Input:  [1, 2, 4, ,6, 3, 7, 8]
        /// Output: 5
        /// </example>
        /// <remarks>Time Complexity: O(n)</remarks>
        /// <see cref="http://www.geeksforgeeks.org/find-the-missing-number/"/>
        public static int Find(int[] input)
        {
            int length = input.Length;
            int total = (length * (length + 1)) / 2; //n(n+1)/2

            for (int i = 0; i < length - 1; i++)
            {
                total -= input[i];
            }

            return total;
        }

        /// <summary>
        /// A XOR B = C => C XOR A = B
        /// (PARTIAL SUM) XOR (MISSING ELEMENT) = (TOTAL) => (TOTAL) XOR (PARTIAL SUM) = (MISSING ELEMENT)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <example></example>
        /// <remarks>Time Complexity: O(n)</remarks>
        /// <see cref="http://www.geeksforgeeks.org/find-the-missing-number/"/>
        /// <seealso cref="http://stackoverflow.com/questions/18335587/finding-the-number-missing-in-the-sequence"/>
        public static int FindXOr(int[] input)
        {
            int n = input.Length;

            int x1 = input[0];
            int x2 = 1;

            //XOR all elements
            for (int i = 1; i < n; i++)
                x1 = x1 ^ input[i];

            //XOR all numbers from 1 to n
            for (int i = 2; i <= n + 1; i++)
                x2 = x2 ^ i;

            //XOR of X1 and X2 gives the missing number.
            return (x1 ^ x2);
        }
    }
}
