namespace com.hack3rlife.algorithms.searching
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class BinarySearch
    {
        /// <summary>
        /// Given a sorted array arr[] and a number x, write a function that counts the occurrences of x in arr[]. 
        /// </summary>
        /// <![CDATA[
        ///         Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 2
        ///         Output: 4
        ///         
        ///         Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 3
        ///         Output: 1 
        ///         
        ///         Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 1
        ///         Output: 2 
        ///         
        ///         Input: arr[] = {1, 1, 2, 2, 2, 2, 3,},   x = 4
        ///         Output: -1 // 4 doesn't occur in arr[] 
        /// ]]>
        /// <see cref="http://www.geeksforgeeks.org/count-number-of-occurrences-in-a-sorted-array/"/>
        /// <param name="input"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Count(int[] input, int x)
        {
            var first = BinarySearch.FindFirstOccurrence(input, x);
            var last = BinarySearch.FindLastOccurrence(input, x);

            if (first == -1)
                return 0;

            return last - first + 1;
        }
    }
}
