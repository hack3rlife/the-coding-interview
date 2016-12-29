using System;
using System.Collections.Generic;

namespace com.hack3rlife.strings
{
    /// <summary>
    /// Evaluate the arithmetic expression in RPN
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Reverse_Polish_notation"/>
    public class ReversePolishNotation
    {
        /// <summary>
        /// Given an array of strings, evaluate the value of an arithmetic expression in Reverse Polish Notation.
        /// </summary>
        /// <param name="tokens">The RPN expression</param>
        /// <returns>The RPN evaluation result.</returns>
        /// <example>
        ///  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
        ///  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
        /// </example>
        public static int EvalRPN(string[] tokens)
        {
            if (tokens == null || tokens.Length <= 0)
                return 0;

            var stack = new Stack<int>();
            var result = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];

                if (IsOperator(token))
                {
                    var x = stack.Pop();
                    var y = stack.Pop();

                    result = DoOperation(x, y, token);

                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            result = stack.Pop();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static bool IsOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/")
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        private static int DoOperation(int x, int y, string o)
        {

            //switch (o)
            //{
            //    case "+":
            //        return x + y;
            //    case "-":
            //        return y - x;
            //    case "*":
            //        return x * y;
            //    case "/":
            //        return y / x;
            //    default:
            //        throw new InvalidOperationException("Invalid Operator");
            //}
            if (o == "+")
            {
                return x + y;
            }
            else if (o == "-")
            {
                return y - x;
            }
            else if (o == "*")
            {
                return x * y;
            }
            else if (o == "/")
            {
                return y / x;
            }
            else
            {
                throw new InvalidOperationException("Invalid Operator");
            }
        }
    }
}
