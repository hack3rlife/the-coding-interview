using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;

namespace BinarySearchTest
{
    [TestClass]
    public class BunarySearchTest
    {
        [TestMethod]
        public void StandardBunarySearchTest()
        {
            //Arrange
            int[] input = new int[] { 1,2,3,4,5 };
            
            //Act
            int? actual = BinarySearch.StandardBinarySearchIterative(input, 4, 0, input.Length - 1);
            int? expected = BinarySearch.StandardBinarySearchRecursive(input, 4, 0, input.Length - 1);
            //Assert
            Assert.AreEqual<int?>(expected, actual);
        }

         [TestMethod]
        public void PivotedBinarySearchTest()
        {
            //Arrange
            int[] input = new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            
            //Act
            int? actual = BinarySearch.PivotedBinarySearch(input, 7);
            int? expected = 2;
            //Assert
            Assert.AreEqual<int?>(expected, actual);
        }
    }
}
