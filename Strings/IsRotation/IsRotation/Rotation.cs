/*
 * @autor: Some smart guy in the milky way
 * @date: 13/01/2015
 * @project: String Combination
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// 
    /// </summary>
    public class Rotation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1">The input string one</param>
        /// <param name="s2">The input string two</param>
        /// <returns></returns>
        public static bool IsRotation(string s1, string s2)
        {
            bool result = false;

            // No ration is both string have different length
            if (s1.Length != s2.Length)
                return result;
            
            //duplicate s1
            s1 += s1;

            int i = 0, count = 0;
            while (i < s1.Length )
            {
                if (s1[i] == s2[count])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (count == s2.Length)
                {
                    result = true;
                    break;
                }

                i++;
            }

            return result;
        }
    }
}
