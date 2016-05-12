using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.algorithms;

namespace LargestPairSumTest
{
    [TestClass]
    public class LargestPairSumTest
    {
        [TestMethod]
        public void LargestPairSumFindTest()
        {
            //arrange
            int[] input = { 12, 34, 10, 6, 40 };

            //act
            int actual = LargestPairSum.Find(input);
            int expected = 74;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
