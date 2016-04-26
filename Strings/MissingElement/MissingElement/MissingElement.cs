﻿/*
 * @autor: Some smart guy on internet
 * @date: 04/28/2015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hectorea.number
{
    /// <summary>
    /// 
    /// </summary>
    public class MissingElement
    {
        /// <summary>
        /// You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates in list. One of the integers is missing in the list. Write an 
        /// efficient code to find the missing integer.
        /// </summary>
        /// <param name="input">The input array</param>
        /// <returns>The issing number</returns>
        /// <see cref="http://www.geeksforgeeks.org/find-the-missing-number/"/>
        public static int Find(int[] input)
        {
            int length = input.Length;
            int total = (length*(length + 1)) / 2; //n(n+1)/2

            for (int i = 0; i < length-1; i++)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <remarks>http://java67.blogspot.com/2014/12/how-to-find-missing-number-in-sorted.html</remarks>
        public static int BinarySearch(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;
            
            while (left <= right)
            {
                int middle = (right + left) >> 1;
                
                if (input[middle] != middle)
                {
                    if (middle == 0 || input[middle - 1] == middle - 1)
                    {
                        return middle;
                    }
                    
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return int.MinValue;
        }
    }
}
