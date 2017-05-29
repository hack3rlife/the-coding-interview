using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.strings
{
    public static class FirstUniqueChar
    {
        /// <summary>
        /// Given a string, find its first non-repeating character
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>The index whithin the string of the first unique char; otherwise -1</returns>
        /// <see cref="http://www.geeksforgeeks.org/given-a-string-find-its-first-non-repeating-character/"/>
        public static int Find(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            int[] dict = new int[256];

            for (int i = 0; i < input.Length; i++)
            {
                dict[input[i]]++;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (dict[input[i]] == 1)
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Find the first non-repeating character from a stream of characters
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <returns>The first non-repeating character in O(1) time at any moment.</returns>
        public static Dictionary<int, char> FindInStream(char[] input)
        {
            if (input == null || input.Length <= 0)
                return null; ;

            int[] dict = new int[256];
            List<char> list = new List<char>();
            Dictionary<int, char> mapping = new Dictionary<int, char>();

            for (int i = 0; i < input.Length; i++)
            {
                Debug.WriteLine(string.Format("Reading '{0}'", input[i]));
                dict[input[i]]++;

                if (dict[input[i]] == 1)
                {
                    list.Add(input[i]);
                }
                else
                {
                    list.Remove(input[i]);
                }

                if (list.Count > 0)
                {
                    mapping.Add(i, list[0]);
                    Debug.WriteLine(string.Format("First non-repeating char '{0}'", list[0]));
                }
                else
                {
                    mapping.Add(i, ' ');
                    Debug.WriteLine(string.Format("Only duplicates"));
                }
            }

            return mapping;
        }
    }
}
