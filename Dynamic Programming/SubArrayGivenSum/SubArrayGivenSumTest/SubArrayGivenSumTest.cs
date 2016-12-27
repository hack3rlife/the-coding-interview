
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming
{
    [TestClass]
    public class SubArrayGivenSumTest
    {
        [TestMethod]
        public void SubArrayGivenSum_GetSubArrayTest_NoError()
        {
            //arrange
            int[] input = { 1, 4, 20, 3, 10, 5 };
            int sum = 33;
            int expected = 1;

            //act
            int[] actual = SubArrayGivenSum.Get(input, sum);

            //assert
            Assert.AreEqual<int>(expected, actual[0]);
        }

        [TestMethod]
        public void SubArrayGivenSum_GetSubArrayTest_Zero()
        {
            //arrange
            int[] input = { 1, 4, 20, 3, 10, 5 };
            int sum = 0;
            int expected = 0;

            //act
            int[] actual = SubArrayGivenSum.Get(input, sum);

            //assert
            Assert.AreEqual<int>(expected, actual[0]);
        }

        [TestMethod]
        public void SubArrayGivenSum_GetSubArrayTest_Error()
        {
            //arrange
            int[] input = { 1, 4, 20, 3, 10, 5 };
            int sum = 220;
            int expected = 0;

            //act
            int[] actual = SubArrayGivenSum.Get(input, sum);

            //assert
            Assert.AreEqual<int>(expected, actual[0]);
        }

      
    }
}
