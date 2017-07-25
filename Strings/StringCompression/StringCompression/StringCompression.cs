using System.Text;

namespace com.hack3rlife.strings
{
    public static class StringCompression
    {
        public static string Zip(string input)
        {
            var sb = new StringBuilder();
            var count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                count++;

                if(i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    sb.Append($"{input[i]}{count}");
                    count = 0;
                }
            }

            return sb.Length > input.Length ? input : sb.ToString();
        }
    }
}
