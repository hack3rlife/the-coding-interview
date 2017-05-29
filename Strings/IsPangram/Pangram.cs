namespace com.hack3rlife.strings
{
    /// <summary>
    /// A Pangram or holoalphabetic sentence is a sentence using every letter of a given alphabet at least once. Pangrams have been used to display typefaces, test equipment, and develop 
    /// skills in handwriting, calligraphy, and keyboarding.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Pangram"/>
    /// <seealso cref="http://clagnut.com/blog/2380/"/>
    public static class Pangram
    {
        /// <summary>
        /// Given a string check if it is Pangram or not. A pangram is a sentence containing every letter in the English Alphabet.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns></returns>
        public static bool IsPangram(string input)
        {

            if (input.Length <= 0)
                return false;

            int[] alphabet = new int[26];

            //Store every char and increment/decrement in one every repetition
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 65 && input[i] <= 90)        //[A-Z]
                    alphabet[input[i] - 65]++;
                else if (input[i] >= 97 && input[i] <= 122)        //[a-z]
                    alphabet[input[i] - 97]++;
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == 0)
                    return false;
            }

            return true;
        }

    }
}
