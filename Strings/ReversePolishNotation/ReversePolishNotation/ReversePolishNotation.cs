using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    public class ReversePolishNotation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
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

        private static bool IsOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/")
                return true;

            return false;
        }

        private static int DoOperation(int x, int y, string o)
        {

            switch (o)
            {
                case "+":
                    return x + y;
                case "-":
                    return y - x;
                case "*":
                    return x * y;
                case "/":
                    return y / x;
                default:
                    throw new InvalidOperationException("Invalid Operator");
            }
            //if (o == "+")
            //{
            //    return x + y;
            //}
            //else if (o == "-")
            //{
            //    return y - x;
            //}
            //else if (o == "*")
            //{
            //    return x * y;
            //}
            //else if (o == "/")
            //{
            //    return y / x;
            //}
            //else
            //{
            //    throw new InvalidOperationException("Invalid Operator");
            //}
        }
    }
}
