using System.Collections.Generic;

namespace BalancedExpressions
{
    public static class BalancedExpressions
    {
        /// <summary>
        /// Verifies if the input string is balanced or not
        /// </summary>
        /// <param name="expression">Input string with the expresion to evaluate</param>
        /// <returns>True is the input string is balanced; false in another case</returns>
        /// <example>
        /// Input: (a+b) * (c-d)            --> True
        /// Input: (z(a + b(x + y)))        --> True
        /// Input: { a/b * (x+y+z) - [c]    --> False
        /// </example>
        public static bool IsBalancedExpression(string expression)
        {
            if (expression.Length <= 0 || expression == string.Empty)
                return false;

            int openParentheses = 0;
            int openBrackets = 0;
            int openCurlyBraces = 0;
            int GreaterOrLesserThan = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                    openParentheses++;
                else if (expression[i] == '[')
                    openBrackets++;
                else if (expression[i] == '{')
                    openCurlyBraces++;
                else if (expression[i] == '<')
                    GreaterOrLesserThan++;
                else if (expression[i] == ')')
                    openParentheses--;
                else if (expression[i] == ']')
                    openBrackets--;
                else if (expression[i] == '}')
                    openCurlyBraces--;
                else if (expression[i] == '>')
                    GreaterOrLesserThan--;

                if (openParentheses < 0 || openBrackets < 0 || openCurlyBraces < 0)
                    return false;
            }

            bool result =
                (openBrackets == 0)
                && (openCurlyBraces == 0)
                && (openParentheses == 0)
                && (GreaterOrLesserThan == 0) ? true : false;

            return result;
        }

        /// <summary>
        /// Verifies if the input string is balanced or not using stacks
        /// </summary>
        /// <param name="expression">Input string with the expresion to evaluate</param>
        /// <returns>True is the input string is balanced; false in another case</returns>
        /// <example>
        /// Input: (a+b) * (c-d)            --> True
        /// Input: (z(a + b(x + y)))        --> True
        /// Input: { a/b * (x+y+z) - [c]    --> False
        /// </example>
        public static bool IsBalancedExpressionWithStacks(string expression)
        {
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
        /// <param name="openTag">Open Tag</param>
        /// <param name="closeTag">Close Tag</param>
        /// <returns>True if the <para>openTag</para> corresponds to the <para>closeTag</para>; false in another case</returns>
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

