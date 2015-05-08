using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.strings
{
    public class LongestCommonSubstring
    {
        public static int GetLCS(string input1, string input2)
        {
            int m = input1.Length;
            int n = input2.Length;

            int[,] num = new int[m, n];

            int result = 0;


            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if(input1[i] == input2[j])
                    {
                        num[i, j] = num[i-1, j-1] + 1;

                        result = (result > num[i, j]) ? result : num[i, j];
                    }
                    else
                    {
                        num[i, j] = 0;
                    }
                }
            }
            return result;
        }
    }
}
