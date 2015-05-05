using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.strings
{
    public  class LowestNumber
    {
        public static void BuildLowestNumber(string input, int n, ref string result)
        {
            if (n == 0)
            {
                 result += input;
                 return;
            }

            int length = input.Length-1;

            if( length <= n)
            {
                 result = string.Empty;
                 return;
            }

            int index = 0;
            for (int i = 1; i <= n; i++)
            {
                if (input[i] < input[index]) 
                    index = i;            
            }            

            result += input[index];

            string substring = input.Substring(index + 1, length - index);

            Console.WriteLine("result: {0} - substring: {1}", result, substring);

            BuildLowestNumber(substring, n - index, ref result);
        }
    }
}
