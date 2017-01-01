using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Next Greater Element
    /// </summary>
    public static class NextGreaterElement
    {
        /// <summary>
        /// Given an array of integers (positive or negative) print the next greater element of all elements in the array.  Otherwise, null.
        /// </summary>
        /// <param name="input">the input array</param>   
        /// <returns></returns>
        /// <remarks>Time Complexity: O(n)</remarks>
        /// <see cref="http://www.geeksforgeeks.org/next-greater-element/"/>
        public static string Get(int[] input)
        {
            var stack = new Stack<int>();
            string output = string.Empty;

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
                    output += pop + "#" + curr + ",";

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
                output += pop + "#" + null + ",";
            }

            return output;
        }
    }
}
