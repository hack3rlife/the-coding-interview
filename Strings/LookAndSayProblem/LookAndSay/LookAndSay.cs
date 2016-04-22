/*
 * @autor: Elementes of Programming Interview
 * @date: 04/18/2016
 * @project: LookAndSay
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// 
    /// </summary>
    public class LookAndSay
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string GetSequence(int n)
        {

            string s = "1";

            for (int i = 1; i < n; ++i)
            {
                s = NextNumber(s.ToCharArray());
            }

            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string NextNumber(char[] input)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; ++i)
            {
                int count = 1;

                while (i + 1 < input.Length && input[i] == input[i + 1])
                {
                    ++i;
                    ++count;
                }

                result += count.ToString() + input[i];
            }

            return result;
        }
    }
}
