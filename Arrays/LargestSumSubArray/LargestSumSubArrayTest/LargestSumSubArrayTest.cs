using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;

namespace LargestSumSubArrayTest
{
    [TestClass]
    public class LargestSumSubArrayTest
    {
        [TestMethod]
        public void GetLargestSumTest()
        {
            //Arrange
            int[] input = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            int expected = 7;

            //Act
            int[] actual = LargestSumSubArray.GetLargestSum(input);

            //Assert
            Assert.AreEqual(expected, actual[0]);
        }
    }
}
