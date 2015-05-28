using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;

namespace LargestPairSumTest
{
    [TestClass]
    public class LargestPairSumTest
    {
        [TestMethod]
        public void LargestPairSumFindTest()
        {
            //Arrange
            int[] input = { 12, 34, 10, 6, 40 };

            //Act
            int actual = LargestPairSum.Find(input);
            int expected = 74;

            //Assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
