using System;
using com.hack3rlife.arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindKthTest
{
    [TestClass]
    public class FindKthLargestTest
    {
        [TestMethod]
        public void FindKth_LargestTest()
        {
            //arrange
            int[] input = { 7, 10, 4, 3, 20, 15 };
            int k = 3;
            var expected = 10;

            //act
            int? actual = FindKthLargest.Select(input, 0, input.Length - 1, 3);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
