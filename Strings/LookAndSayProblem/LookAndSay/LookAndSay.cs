/*
 * @autor: Elementes of Programming Interview
 * @date: 04/18/2016
 * @project: LookAndSay
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// Look-and-Say Sequence
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Look-and-say_sequence"/>
    public class LookAndSay
    {
        /// <summary>
        /// Find the n’th term in Look-and-say (Or Count and Say) Sequence.
        /// </summary>
        /// <example>1, 11, 21, 1211, 111221, 312211, 13112221, 1113213211, …</example>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string GetSequence(int n)
        {
            if (n < 0)
                return string.Empty;

            if (n == 0) return "1";
            if (n == 1) return "11";

            string s = "11";

            for (int i = 2; i < n; ++i)
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
