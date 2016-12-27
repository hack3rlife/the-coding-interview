using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.Test
{
    [TestClass()]
    public class LargestSubarrayWithZeroSumTest
    {
        [TestMethod]
        public void LargestSubarrayWithZeroSum_Get_Test()
        {
            //arrange   
            int[] input = { 15, -2, 2, -8, 1, 7, 10, 23 };
            int expected = 5;

            //act
            int[] actual = LargestSubarrayWithZeroSum.Get(input);

            //assert
            Assert.AreEqual<int>(expected, actual[0]);
        }
    }
}