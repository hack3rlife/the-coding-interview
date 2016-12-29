namespace com.hack3rlife.strings
{
    /// <summary>
    /// Two strings str1 and str2 are called isomorphic if there is a one to one mapping possible for every character of str1 to every character of str2. And all occurrences of every 
    /// character in ‘str1’ map to same character in ‘str2’
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Isomorphism"/>
    public static class Isomorphic
    {
        /// <summary>
        /// Check if two given strings are isomorphic to each other
        /// </summary>
        /// <param name="input1">The input string one</param>
        /// <param name="input2">The input string two</param>
        /// <returns>True if the both string are isomorphic: otherwise false</returns>
        /// <example>
        /// "egg", "add", returns true.
        /// "foo", "bar", returns false.
        /// "paper", "title", returns true.
        /// "aab", "xxy", returns true
        /// </example>
        /// <remarks>
        /// Time Complexity O(n)
        /// Space Complexity O(2n)
        /// </remarks>
        /// <see cref="http://www.geeksforgeeks.org/check-if-two-given-strings-are-isomorphic-to-each-other/"/>
        public static bool IsIsomorphic(string input1, string input2)
        {
            if (input1.Length != input1.Length)
                return false;

            //Assuming the string could be any char represented in the ASCII Table
            int[] alphabet = new int[256];
            bool[] visited = new bool[256];

            for (int i = 0; i < input1.Length; i++)
            {
                if (alphabet[input1[i]] == 0)
                {
                    if (visited[input2[i]] == true)
                        return false;

                    visited[input2[i]] = true;

                    alphabet[input1[i]] = input2[i];
                }
                else
                {
                    if (alphabet[input1[i]] != input2[i])
                        return false;
                }

            }
            return true;
        }
    }
}