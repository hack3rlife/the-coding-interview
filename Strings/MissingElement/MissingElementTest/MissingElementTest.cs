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
            //Arrange
            int[] input = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //Act
            int actual = MissingElement.Find(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMissingElementWithBinarySearchTest()
        {
            //Arrange
            int[] input = new int[] { 0, 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //Act
            int actual = MissingElement.BinarySearch(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMissingElementUsingXOrTest()
        {
            //Arrange
            int[] input = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //Act
            int actual = MissingElement.FindXOr(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
