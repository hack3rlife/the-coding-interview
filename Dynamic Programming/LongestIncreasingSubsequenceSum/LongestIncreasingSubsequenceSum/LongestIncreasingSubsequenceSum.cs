namespace com.hack3rlife.dynamicprogramming
{
    public static class LongestIncreasingSubsequenceSum
    {
        public static int Get(int[] input)
        {
            int[] result = new int[input.Length];
            input.CopyTo(result, 0);

            int[] indexes = Initialize(new int[input.Length]);

            int i = 1;
            int j = 0;

            int sum = 0;
            int curr = 0;
            int max = 0;

            //edge case when first value is the highest in the array
            if (input[j] > input[i])
            {
                max = input[0];
                result[j] = max;
                i++;
            }

            while (i < input.Length)
            {
                j = 0;
                while (j < i)
                {

                    if (input[j] < input[i])
                    {
                        sum = input[i] + result[j];
                        curr = result[i];

                        if (sum > curr && sum > max)
                        {
                            max = sum;
                            result[i] = sum;
                            indexes[i] = j;
                        }
                    }                    

                    j++;
                }

                i++;
            }

            return max;

        }


        private static int[] Initialize(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i;
            }

            return input;
        }

        private static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
