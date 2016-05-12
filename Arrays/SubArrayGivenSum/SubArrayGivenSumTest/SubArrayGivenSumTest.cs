using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.algorithms;

namespace SubArrayGivenSumTest
{
    [TestClass]
    public class SubArrayGivenSumTest
    {
        [TestMethod]
        public void GetSubArrayTest()
        {
            //arrange
            int[] input = { 1, 4, 20, 3, 10, 5 };
            int sum = 33;
            int expected = 1;

            //act
             int[] actual = SubArrayGivenSum.GetSubArrayForGivenSum(input, sum);

            //assert
            Assert.AreEqual<int>(expected, actual[0]);
        }

        [TestMethod]
        public void GetSubArrayWithSumZeroTest()
        {
            //arrange
            int[] input = { 15, -2, 2, -8, 1, 7, 10, 23 };
            int sum = 0;
            int expected = 1;

            //act
            int[] actual = SubArrayGivenSum.GetSubArrayWithSumZero(input);

            //assert
            Assert.AreEqual<int>(expected, actual[0]);
        }
    }
}
