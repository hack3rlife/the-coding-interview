using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.strings
{
    public class NaivePatternSearching
    {
        public static int Search(string pattern, string input)
        {
            int patternLength = pattern.Length;
            int inputLength = input.Length;

            for (int i = 0; i < inputLength-patternLength; i++)
            {
                for (int j = 0; j < patternLength; j++)
                {
                    if (input[i + j] != pattern[j])
                    {
                        break;
                    }

                    if (j == patternLength-1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
