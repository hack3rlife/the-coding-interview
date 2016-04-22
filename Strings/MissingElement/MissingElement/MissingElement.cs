namespace com.hectorea.missingelement
{
    public class MissingElement
    {

        /// <summary>
        /// Assuming there is no duplicates, only one value is missing in the sequence and the array is sorted
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Find(int[] input)
        {
            int length = input.Length;
            int total = (length*(length + 1)) / 2; //n(n+1)/2

            for (int i = 0; i < length-1; i++)
            {
                total -= input[i];
            }

            return total;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <remarks>http://java67.blogspot.com/2014/12/how-to-find-missing-number-in-sorted.html</remarks>
        public static int BinarySearch(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;
            
            while (left <= right)
            {
                int middle = (right + left) >> 1;
                
                if (input[middle] != middle)
                {
                    if (middle == 0 || input[middle - 1] == middle - 1)
                    {
                        return middle;
                    }
                    
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return int.MinValue;

        }

    }
}
