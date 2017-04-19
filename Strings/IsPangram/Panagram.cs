namespace com.hack3rlife.strings
{
    public static class Panagram
    {
        public static bool IsPanagram(string input)
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
