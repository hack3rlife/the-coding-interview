using System;
using com.hack3rlife.algorithms.searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting.test
{
    [TestClass]
    public class FindMissingElementTest
    {
        [TestMethod]
        public void FindMissingElementWithBinarySearchTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 12, 13, 14, 16, 17, 18 };
            int expected = 15;

            //act
            int actual = BinarySearch.FindMissingElement(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
