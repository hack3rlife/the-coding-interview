using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.hack3rlife.stringcombination
{
    public class StringCombination
    {
        public static void Combine(string input, string output, int current)
        {
            for (int i = current; i < input.Length; i++)
            {
                output += input[i];
                Console.WriteLine(output);
                Combine(input, output, i + 1);
                output = output.Remove(output.Length - 1);
            }
        }
    }
}
