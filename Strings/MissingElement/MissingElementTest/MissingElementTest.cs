using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hectorea.number;

namespace MissingElementTest
{
    [TestClass]
    public class MissingElementTest
    {
        [TestMethod]
        public void FindMissingElementTest()
        {
            //arrange
            int[] input = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //act
            int actual = MissingElement.Find(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMissingElementWithBinarySearchTest()
        {
            //arrange
            int[] input = new int[] { 0, 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //act
            int actual = MissingElement.BinarySearch(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMissingElementUsingXOrTest()
        {
            //arrange
            int[] input = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //act
            int actual = MissingElement.FindXOr(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
