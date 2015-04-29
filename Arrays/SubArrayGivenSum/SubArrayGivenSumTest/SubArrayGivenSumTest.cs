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

            //Act
           bool condition = SubArrayGivenSum.GetSubArray(input, sum);
            
            //Assert
           Assert.IsTrue(condition);
        }
    }
}
