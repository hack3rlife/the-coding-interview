using System.Collections.Generic;

namespace com.hack3rlife.strings
{
    /// <summary>
    /// Check for balanced parentheses in an expression
    /// </summary>
    public static class BalancedExpressions
    {
        /// <summary>
        /// Given an expression string, write a program to examine whether the pairs and the orders of “{“,”}”,”(“,”)”,”[“,”]” are correct in expression.
        /// </summary>
        /// <param name="expression">Input string with the expresion to evaluate.</param>
        /// <returns>True is the input string is balanced; otherwise false.</returns>
        /// <example>
        /// Input: (a+b) * (c-d)            --> True
        /// Input: (z(a + b(x + y)))        --> True
        /// Input: { a/b * (x+y+z) - [c]    --> False
        /// </example>
        /// <remarks>
        /// Time Complexity: O(n)
        /// Space Complexity: O(n) for stack.
        /// </remarks>
        /// <see cref="http://www.geeksforgeeks.org/check-for-balanced-parentheses-in-an-expression/"/>
        public static bool IsBalancedExpressionWithStacks(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return false;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                //If it is an open tag I add it to the stack
                if (expression[i] == '(' || expression[i] == '<' || expression[i] == '[' || expression[i] == '{')
                {
                    stack.Push(expression[i]);

                }//If it is a close tag I remove it from the stack
                else if (expression[i] == ')' || expression[i] == '>' || expression[i] == ']' || expression[i] == '}')
                {
                    //If the stack is null and the current element is a closing tag, return false
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char current = stack.Pop();
                        //if the current tag (open tag) in the stack and 
                        //the current tag (close tag) in the iteration are
                        //do not match, return false                        
                        if (AreOpenAndCloseTags(current, expression[i]) == false)
                        {
                            return false;
                        }
                    }
                }
            }

            return (stack.Count == 0) ? true : false;
        }

        /// <summary>
        /// Check if the <para>openTag</para> corresponds to the <para>closeTag</para>
        /// </summary>
        /// <param name="openTag">The Open Tag</param>
        /// <param name="closeTag">The Close Tag</param>
        /// <returns>True if the <para>openTag</para> corresponds to the <para>closeTag</para>; otherwise false.</returns>
        private static bool AreOpenAndCloseTags(char openTag, char closeTag)
        {
            if (openTag == '(' && closeTag == ')')
                return true;
            else if (openTag == '<' && closeTag == '>')
                return true;
            else if (openTag == '[' && closeTag == ']')
                return true;
            else if (openTag == '{' && closeTag == '}')
                return true;

            return false;
        }
    }
}

