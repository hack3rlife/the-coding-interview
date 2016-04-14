namespace com.hack3rlife.bubblesort
{
    /// <summary>
    /// Implements Bubble Sort Algorithm using XOR
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>
        /// <remarks>
        /// Worst case: О(n2)
        /// Average case: О(n2)
        /// Best Case: O(n)
        /// Space Required: O(n)
        /// </remarks>
        /// <param name="input"></param>        
        /// <returns>/></returns>
        /// <see cref=""/>
        /// <![CDATA[input: |8|4|1|6|2|0| output: |0|1|2|4|6|8|]]>
        public int[] Sort(int[] input)
        {
            if (input == null)
            {
                throw new System.NullReferenceException("input");
            }
            
            //first loop to iterate through the full array
            for (int i = 0; i < input.Length; i++)
            {
                //secondd loop to check values from the current position of 'i' vs 'j'
                for (int j = i + 1; j < input.Length; j++)
                {
                    //check the lowest value and swap them: smaller in the left side; bigger in the right side
                    if (input[i] < input[j])
                    {
                        input[i] ^= input[j];
                        input[j] ^= input[i];
                        input[i] ^= input[j];
                    }
                }
            }

            return input;
        }
    }
}
