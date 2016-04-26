using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;

namespace SubArrayGivenSumTest
{
    [TestClass]
    public class SubArrayGivenSumTest
    {
        [TestMethod]
        public void GetSubArrayTest()
        {
            //Arrange
            int[] input = { 1, 4, 20, 3, 10, 5 };
            int sum = 33;
            int expected = 1;

            //Act
             int[] actual = SubArrayGivenSum.GetSubArrayForGivenSum(input, sum);

            //Assert
            Assert.AreEqual<int>(expected, actual[0]);
        }

        [TestMethod]
        public void GetSubArrayWithSumZeroTest()
        {
            //Arrange
            int[] input = { 15, -2, 2, -8, 1, 7, 10, 23 };
            int sum = 0;
            int expected = 1;

            //Act
            int[] actual = SubArrayGivenSum.GetSubArrayWithSumZero(input);

            //Assert
            Assert.AreEqual<int>(expected, actual[0]);
        }
    }
}
