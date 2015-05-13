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

        /// <summary>
        /// Brute Force
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string LonguestPalindrome(string input)
        {
            string palindrome = string.Empty;
            string word = string.Empty;

            int i = 0;
            while (i < input.Length)
            {
                word += input[i];

                int j = i + 1;
                while (j < input.Length)
                {
                    word += input[j];

                    if (IsPalindrome(word))
                    {
                        if (word.Trim().Length > palindrome.Trim().Length)
                        {
                            palindrome = word;
                        }
                    }

                    j++;
                }

                i++;

                word = string.Empty;
            }

            return palindrome;
        }

        public static string LonguestPalindrome(string[] input)
        {
            int length = input.Length;

            bool[][] table = new bool[length][];

            // All substrings of length 1 are palindromes
            int maxLength = 1;
         
            for (int i = 0; i < length; ++i)
                table[i][i] = true;

            // check for sub-string of length 2.
            int start = 0;
            for (int i = 0; i < length - 1; ++i)
            {
                if (input[i] == input[i + 1])
                {
                    table[i][i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for lengths greater than 2. k is length of substring
            for (int k = 3; k <= length; ++k)
            {
                // Fix the starting index
                for (int i = 0; i < length - k + 1; ++i)
                {
                    // Get the ending index of substring from
                    // starting index i and length k
                    int j = i + k - 1;

                    // checking for sub-string from ith index to
                    // jth index iff str[i+1] to str[j-1] is a
                    // palindrome
                    if (table[i + 1][j - 1] && input[i] == input[j])
                    {
                        table[i][j] = true;

                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }
        }
    }
}
