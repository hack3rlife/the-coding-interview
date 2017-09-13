/*
 * @autor: Elementes of Programming Interview
 * @date: 04/04/2016
 * @project: PhoneNumberMnemonic
 * 
 */

using System.Collections.Generic;
using System.Diagnostics;

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
        /// <example>
        /// For example if input number is 234, possible words which can be formed are (Alphabetical order):
        /// adg adh adi aeg aeh aei afg afh afi bdg bdh bdi beg beh bei bfg bfh bfi cdg cdh cdi ceg ceh cei cfg cfh cfi
        /// </example>
        /// <see cref="http://www.geeksforgeeks.org/find-possible-words-phone-digits/"/>
        public static string Get(string number)
        {
            var result = string.Empty;

            PhoneMnemonicHelper(number, string.Empty, ref result);

            return result.TrimStart();
        }

        /// <summary>
        /// Recursive function to get all the possible combination of the given number
        /// </summary>
        /// <param name="number">The phone number</param>
        /// <param name="current">The current (partial) phone mnemonic</param>
        /// <param name="result">List that holds the phone mnemonic</param>
        /// <see cref="http://blog.welkinlan.com/2015/10/25/letter-combinations-of-a-phone-number-leetcode-java/"/>
        private static void PhoneMnemonicHelper(string number, string current, ref string result)
        {
            if (number.Length == current.Length)
            {
                result = result + " " + current.ToLowerInvariant();
                return;
            }
             
            var currentLetters = GetLetters(number[current.Length]);
            foreach (var c in currentLetters)
            {
                PhoneMnemonicHelper(number, current + c, ref result);
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
                    return "WXYZ";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <see cref="https://algorithmstuff.wordpress.com/tag/letter-combinations-of-a-phone-number/"/>
        public static string Map(string number)
        {
            var result = string.Empty;

            Combinations(number, 0, string.Empty, ref result);

            return result.TrimStart();
        }

        /// <summary>
        /// Find all possible combinations of the given string with fix length.
        /// </summary>
        /// <param name="number">The input string<./param>
        /// <param name="index">The current index.</param>
        /// <param name="output">The current (temporary) output.</param>
        private static void Combinations(string number, int index, string output, ref string result)
        {
            if (index == number.Length)
            {
                Debug.WriteLine(output);
                result = result + " " + output.ToLowerInvariant();
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
                Combinations(number, index + 1, output, ref result);
                output = output.Remove(output.Length - 1);
            }
        }


    }
}
