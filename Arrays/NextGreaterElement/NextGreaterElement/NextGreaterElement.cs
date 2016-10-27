using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Given an array of integers (positive or negative) print the next greater element of all elements in the array.  Otherwise, null.
    /// </summary>
    public static class NextGreaterElement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>        
        public static void Get(int[] input)
        {
            var stack = new Stack<int>();

            stack.Push(input[0]);
            //int[] input = { 98, 23, 54, 12, 20, 7, 27 };
            for (int i = 1; i < input.Length; i++)
            {
                var peek = stack.Peek();
                var curr = input[i];

                while (curr > peek)
                {
                    var pop = stack.Pop();
                    Debug.WriteLine("Next Greater Element of {0} is {1}", pop, curr);

                    if (stack.Count == 0)
                        break;
                    else
                        peek = stack.Peek();
                }

                stack.Push(curr);                
            }

            while (stack.Count > 0)
            {
                var pop = stack.Pop();

                Debug.WriteLine("Next Greater Element of {0} is null", pop, null);
            }
        }
    }
}
