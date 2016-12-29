using System;

namespace com.hackerlife.strings
{
    public class WildCardMatch
    {
        public static bool IsMatch(string input, string wildcard)
        {
            int i = 0;
            int j = 0;


            while (i < wildcard.Length && j < input.Length)
            {
                if (wildcard[i] == '*')
                {
                    if (i + 1 < wildcard.Length)
                    {
                        if (wildcard[i + 1] != input[j])
                            j++;
                        else
                            i++;
                    }
                    else
                    {
                        j++;
                    }
                }
                else if (wildcard[i] == '?' || wildcard[i] == input[j])
                {
                    i++;
                    j++;
                }
                else if (wildcard[i] != input[j])
                {
                    return false;
                }

            }

            return true;
        }
    }
}
