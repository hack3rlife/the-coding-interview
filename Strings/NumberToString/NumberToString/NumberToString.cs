using System;
namespace com.hack3rlife.strings
{
    //TODO: Get the current strings instead just printing them
    public class NumberToString
    {
        public static void NumberToStringMapping(string number)
        {
            Combinations(number, 0, string.Empty);
        }

        private static void Combinations(string number, int index, string output)
        {
            if (index == number.Length)
            {
                Console.WriteLine(output);
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
    }
}
