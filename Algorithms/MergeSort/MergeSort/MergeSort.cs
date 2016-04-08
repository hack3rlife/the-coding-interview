namespace com.hack3rlife.mergesort
{
    /// <summary>
    /// Implements Merge Sort Algorithm
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Receives an unsorted array of integers and sort it in ascending order
        /// </summary>
        /// <param name="input"></param>
        /// <returns>A sorted array of <see cref="System.Int16"/></returns>
        /// <![CDATA[input: |8|4|1|6|2|0| output: |0|1|2|4|6|8|]]>
        public int[] Sort(int[] input)
        {
            if (input == null)
            {
                throw new System.NullReferenceException("input");
            }

            if (input.Length == 1)
                return input;

            // Split the array in two 
            int mid = input.Length / 2;

            int[] left = new int[mid];
            for (int i = 0; i < left.Length; i++)
                left[i] = input[i];

            int[] right = new int[input.Length - mid];
            for (int i = 0; i < right.Length; i++)
                right[i] = input[mid++];

            // Recursive calls
            // 1. Recursive call to Sort(int[]) to break the array into smaller pieces
            // 2. After Sort(int[]) finish, we merge both arrays 
            return Merge(Sort(left), Sort(right));
        }

        /// <summary>
        /// Merges two ssorted arrays into a sorted array
        /// </summary>
        /// <param name="left">Left sorted array</param>
        /// <param name="right">Right sorted array</param>
        /// <returns>A sorted arrays of <see cref="System.Int16"/></returns>
        private static int[] Merge(int[] left, int[] right)
        {
            //Temporal array to store the result
            int[] merged = new int[left.Length + right.Length];

            int i = 0, j = 0, k = 0;

            while (k < merged.Length)
            {
                //if both arrays are in boundaries
                if (i < left.Length && j < right.Length)
                {
                    //check what value is the lowest and it's stored it in the current position of k  (sort the array in ascending order)    
                    //if you wish to sort in descending ordder, just change the operator from '<' to '>'          
                    if (left[i] < right[j])
                    {
                        //assign left[i] to merged[k]
                        //increment k + 1
                        //increment i + 1
                        //j remains in the same position
                        merged[k++] = left[i++];
                    }
                    else
                    {
                        //assign right[j] to merged[k]
                        //increment k + 1
                        //increment j + 1
                        //i remains in the same position
                        merged[k++] = right[j++];
                    }
                }
                else if (i < left.Length)     //if just left array
                    merged[k++] = left[i++];
                else if (j < right.Length)     //if just right array
                    merged[k++] = right[j++];
            }

            return merged;
        }
    }
}