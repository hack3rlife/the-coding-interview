/*
 * @autor: Elementes of Programming Interview
 * @date: 04/04/2016
 * @project: PhoneNumberMnemonic
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// A mnemonic mnemonic device, or memory device is any learning technique that aids information retention in the human memory.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Mnemonic"/>
    public class PhoneNumberMnemonic
    {
        /// <summary>
        /// Given a number string, return all possible letter combinations that the number could represent.
        /// </summary>
        /// <param name="number">The input string</param>
        /// <returns>All possible letter combinations that the number could represent.</returns>
        /// <see cref="http://www.geeksforgeeks.org/find-possible-words-phone-digits/"/>
        public static System.Collections.Generic.List<string> Get(string number)
        {
            var result = new System.Collections.Generic.List<string>();

            PhoneMnemonicHelper(number, string.Empty, result);

            return result;
        }

        /// <summary>
        /// Recursive function to get all the possible combination of the given number
        /// </summary>
        /// <param name="number">The phone number</param>
        /// <param name="current">The current (partial) phone mnemonic</param>
        /// <param name="result">List that holds the phone mnemonic</param>
        /// <see cref="http://blog.welkinlan.com/2015/10/25/letter-combinations-of-a-phone-number-leetcode-java/"/>
        private static void PhoneMnemonicHelper(string number, string current, System.Collections.Generic.List<string> result)
        {
            if (number.Length == current.Length)
            {
                result.Add(current.ToLowerInvariant());
                return;
            }

            var currentLetters = GetLetters(number[current.Length]);
            foreach (var c in currentLetters)
            {
                PhoneMnemonicHelper(number, current + c, result);
            }
            
        }

        /// <summary>
        /// Map function
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string GetLetters(char number)
        {
            switch (number)
            {
                case '2':
                    return "ABC";
                case '3':
                    return "DEF";
                case '4':
                    return "GHI";
                case '5':
                    return "JKL";
                case '6':
                    return "MNO";
                case '7':
                    return "PQRS";
                case '8':
                    return "TUV";
                case '9':
                    return "XYZ";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <see cref="https://algorithmstuff.wordpress.com/tag/letter-combinations-of-a-phone-number/"/>
        public static void Map(string number)
        {
            Combinations(number, 0, string.Empty);
        }

        /// <summary>
        /// Find all possible combinations of the given string with fix length.
        /// </summary>
        /// <param name="number">The input string<./param>
        /// <param name="index">The current index.</param>
        /// <param name="output">The current (temporary) output.</param>
        private static void Combinations(string number, int index, string output)
        {
            if (index == number.Length)
            {
                System.Console.WriteLine(output);
                return;
            }

            var currentLetters = GetLetters(number[index]);

            /* un-comment if want to include numbers */
            //output += number[index];
            //Combinations(number, index + 1, output);
            //output = output.Remove(output.Length - 1);

            for (int i = 0; i < currentLetters.Length; i++)
            {
                output += currentLetters[i];
                Combinations(number, index + 1, output);
                output = output.Remove(output.Length - 1);
            }
        }

        
    }
}
