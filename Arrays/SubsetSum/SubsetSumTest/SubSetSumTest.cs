using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;

namespace SubsetSumTest
{
    [TestClass]
    public class SubSetSumTest
    {
        [TestMethod]
        public void GetSubSetSumTest()
        {
            //Arrange
            int[] input = new int[] { 3, 34, 4, 12, 5, 2 };

            //Act
            bool condition = SubSetSum.HasSubSetSum(input, input.Length, 7);

            //Assert
            Assert.IsTrue(condition);
        }
    }
}
