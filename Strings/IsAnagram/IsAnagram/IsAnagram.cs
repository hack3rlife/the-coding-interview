using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.strings
{
    public class IsAnagram
    {
        public static bool ASCIIBasedSolution( string source, string target)
        {
            if (source.Length <= 0 || target.Length <= 0)
                return false;
            if (source.Length != target.Length)
                return false;

            //I'm assuming the string could be any char represented in the ASCII Table
            int[] alphabet = new int[256];

            //Store every char and increment/decrement in one every repetition
            for (int i = 0; i < source.Length; i++)
            {
                alphabet[source[i]]++;
                alphabet[target[i]]--;
            }


            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] != 0)
                    return false;
            }

            return true;
        }      


    }
}
