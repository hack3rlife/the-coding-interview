/*
 * @autor: Some smart guy on internet
 * @date: 05/15/2015
 * @project: ConcatenateTwoNumbers
 * 
 */

namespace com.hack3rlife.numbers
{
    public class SwappingNumbers
    {
        /// <summary>
        /// Using bitwise operations (XOR)
        /// </summary>
        /// <param name="a">Integer Value</param>
        /// <param name="b">Integer Value</param>
        public static void BitwiseSwap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        /// <summary>
        /// Using simple addition and subtraction operations
        /// </summary>
        /// <param name="a">Interger Value</param>
        /// <param name="b">Integer Value</param>
        public static void ArithmeticSwap(ref int a, ref int b)
        {
            a = a + b;  //Stores temporally the value of b in a
            b = a - b;  //Removes the value of b and we get the value of a in b
            a = a - b;  //Removes the value of a and we get the value of b in a
            // Got it? A little bit tricky, he?
        }        
    }
}
