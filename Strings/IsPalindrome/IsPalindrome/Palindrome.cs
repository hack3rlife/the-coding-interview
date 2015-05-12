namespace com.hack3rlife.strings
{
    public class Palindrome
    {
        /// <summary>
        ///  Check whether a string is palindrome or not
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>True if the string is palindrome; false in another case</returns>
        public static bool IsPalindrome( string input)
        {
            if (input == string.Empty || input.Length <= 1)
                return false;

            int i = 0, j = input.Length - 1;
            while (i < j)
            {
                //ignore blank spaces
                while (i < input.Length && input[i] == ' ')
                    i++;
                while (j >= 0 && input[j] == ' ')
                    j--;

                if (i >= input.Length || j < 0 || input[i] != input[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
