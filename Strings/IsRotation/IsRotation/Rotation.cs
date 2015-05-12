namespace com.hack3rlife.strings
{
    public class Rotation
    {
        public static bool IsRotation(string source, string target)
        {
            bool result = false;

            if (source.Length != target.Length)
                return result;

            source += source;

            int i = 0, count = 0;
            while (i < source.Length )
            {
                if (source[i] == target[count])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (count == target.Length)
                {
                    result = true;

                    break;
                }

                i++;
            }

            return result;
        }
    }
}
