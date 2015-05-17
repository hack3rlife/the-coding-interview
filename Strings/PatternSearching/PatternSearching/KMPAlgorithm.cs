using System;

namespace com.hack3rlife.strings
{
    public class KMPAlgorithm
    {
        static int[] lps;

        public static int Search(string pattern, string input)
        {
            int patternLength = pattern.Length;
            int inputLength = input.Length;

            int index = -1;

            CalculateLpsArray(pattern);

            int i = 0;
            int j =0;

            while (i < inputLength)
            {
                if (input[i] == pattern[j])
                {
                    i++;
                    j++;
                }

                if (j == patternLength - 1)
                {
                    Console.WriteLine("Found pattern at index: {0}", i - j);
                    index = i - j;
                    j = lps[j - 1];
                }
                else if (i < inputLength && input[i] != pattern[j])  // mismatch after j matches
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }


            return index;
        }

        private static void CalculateLpsArray(string pattern)
        {
            int length = 0;
            int i = 1;

            lps = new int[pattern.Length];
            lps[0] = 0;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[length])
                {
                    lps[i++] = ++length;
                }
                else
                {
                    if (length != 0)
                    {
                        length = lps[length - 1];
                    }
                    else
                    {
                        lps[i++] = 0;
                    }
                }
            }
        }
    }
}