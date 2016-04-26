/*
 * @autor: Some smart guy on internet
 * @date: 05/13/2015
 * @project: NextGreaterNumber
 * 
 */
 
namespace com.hack3rlife.strings
{
    public class NextGreaterNumber
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/find-next-greater-number-set-digits/"/>
        public static string Next(string number)
        {
            string result = string.Empty;
            int i;

            //from right to left, find the first digit that is
            // smaller than the digit next to it
            for (i = number.Length-1; i > 0; i--)
            {
                if (number[i] > number[i - 1])
                    break;
            }

            if (i == 0)
                return string.Empty;

            //find the smallest digit on right side of (i-1)'th digit that is
            // greater than number[i-1]
            int indexSmallest = i;
            for (int j = i+1; j < number.Length; j++)
            {
                if (number[j] > number[i - 1] &&
                    number[j] < number[indexSmallest])
                {
                    indexSmallest = j;
                    }
            }

            result = Swap(number.ToCharArray(0, number.Length), i-1, indexSmallest);


            result = Sort(result.ToCharArray(0, result.Length), i, result.Length);

            return result;
                
        }

        private static string Swap(char[] input, int i, int j)
        {
            if (i != j)
            {
                input[i] ^= input[j];
                input[j] ^= input[i];
                input[i] ^= input[j];
            }

            return new string(input);
        }

        private static string Sort(char[] input, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                for (int j = i + 1; j < end; j++)
                {
                    if (input[i] > input[j])
                    {
                        input[i] ^= input[j];
                        input[j] ^= input[i];
                        input[i] ^= input[j];
                    }
                }
            }

            return new string(input);
        }
    }
}
