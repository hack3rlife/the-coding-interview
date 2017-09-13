using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.strings
{
    /// <summary>
    /// Find the first non-repeating character in a String
    /// </summary>
    public static class FirstUniqueChar
    {
        /// <summary>
        /// Given a string, find its first non-repeating character
        /// </summary>
        /// <![CDATA[
        /// s = "leetcode",  return 0.
        /// s = "loveleetcode", return 2.
        /// ]]>
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
        /// <![CDATA[
        /// input = "aabbabacdefe"
        /// 
        /// output:
        /// Reading 'a'
        /// First non-repeating char 'a'        
        /// Reading 'a'        
        ///  Only duplicates        
        ///  Reading 'b'        
        ///  First non-repeating char 'b'        
        ///  Reading 'b'        
        ///  Only duplicates        
        ///  Reading 'a'        
        ///  Only duplicates        
        ///  Reading 'b'        
        ///  Only duplicates        
        ///  Reading 'a'        
        ///  Only duplicates        
        ///  Reading 'c'        
        ///  First non-repeating char 'c'        
        ///  Reading 'd'        
        ///  First non-repeating char 'c'        
        ///  Reading 'e'        
        ///  First non-repeating char 'c'        
        ///  Reading 'f'        
        ///  First non-repeating char 'c'        
        ///  Reading 'e'        
        ///  First non-repeating char 'c'
        /// ]]>
        /// <see cref="http://www.geeksforgeeks.org/find-first-non-repeating-character-stream-characters/"/>
        public static Dictionary<int, char> FindInStream(char[] input)
        {
            if (input == null || input.Length <= 0)
                return null; ;

            int[] dict = new int[256];                                      //stores all the different ASCII allowed chars            
            List<char> list = new List<char>();                             //stores the first non-repeating character so far
            Dictionary<int, char> mapping = new Dictionary<int, char>();    //stores the first non-repeating character through the stream

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
