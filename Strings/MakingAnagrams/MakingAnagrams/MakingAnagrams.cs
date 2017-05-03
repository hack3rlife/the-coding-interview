using System.Diagnostics;

namespace com.hack3rlife.strings
{
    public class MakingAnagrams
    {
        public static int Get(string s1, string s2)
        {
            int count = 0;

            //I'm assuming the string could be any char represented in the ASCII Table
            int[] alphabet = new int[256];

            //Store every char and increment/decrement in one every repetition
            for (int i = 0; i < s1.Length; i++)
            {
                alphabet[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                alphabet[s2[i]]--;
            }

            Print(alphabet);

            for (int i = 0; i < alphabet.Length; i++)
            {

                if (alphabet[i] != 0)
                    count += System.Math.Abs(alphabet[i]);
            }

            return count;
        }

        public static void Print(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Debug.WriteLine(input[i]);
            }
        }
    }
}
