using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.algorithms;

namespace LargestSumSubArrayTest
{
    [TestClass]
    public class LargestSumSubArrayTest
    {
        [TestMethod]
        public void GetLargestSumTest()
        {
            //arrange
            int[] input = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            int expected = 7;

            //act
            int[] actual = LargestSumSubArray.GetLargestSum(input);

            //assert
            Assert.AreEqual(expected, actual[0]);
        }
    }
}
