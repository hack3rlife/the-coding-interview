namespace com.hack3rlife.strings
{
    public  class LowestNumber
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <param name="result"></param>
        /// <see cref="http://www.geeksforgeeks.org/build-lowest-number-by-removing-n-digits-from-a-given-number/"/>
        public static void BuildLowestNumber(string input, int n, ref string result)
        {
            if (n == 0)
            {
                 result += input;
                 return;
            }

            int length = input.Length-1;

            if( length <= n)
            {
                 result = string.Empty;
                 return;
            }

            int index = 0;
            for (int i = 1; i <= n; i++)
            {
                if (input[i] < input[index]) 
                    index = i;            
            }            

            result += input[index];

            string substring = input.Substring(index + 1, length - index);

            BuildLowestNumber(substring, n - index, ref result);
        }
    }
}
