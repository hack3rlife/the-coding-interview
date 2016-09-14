using com.hack3rlife.algorithms.searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting.test
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_KeyIsInLeftSideTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 27, 29, 48, 50 };
            int expected = 1;

            //act
            int? actual = BinarySearch.Search(input, 11);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_KeyIsInRightSideTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 27, 29, 48, 50 };
            int expected = 4;

            //act
            int? actual = BinarySearch.Search(input, 48);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_KeyIsLastElementTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 27, 29, 48, 50 };
            int expected = 5;

            //act
            int? actual = BinarySearch.Search(input, 50);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_KeyIsFirstElementTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 27, 29, 48, 50 };
            int expected = 0;

            //act
            int? actual = BinarySearch.Search(input, 10);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_KeyIsMiddleElementTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 27, 29, 48 };
            int expected = 2;

            //act
            int? actual = BinarySearch.Search(input, 27);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_NoKeyFoundTest()
        {
            //arrange
            int[] input = new int[] { 10, 11, 27, 29, 48, 50 };
            int? expected = null;

            //act
            int? actual = BinarySearch.Search(input, 0);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_NegativeNumbersTest()
        {
            //arrange
            int[] input = new int[] { -10, -4, -2, 0, 1, 2, 10 };
            int expected = 2;

            //act
            int? actual = BinarySearch.Search(input, -2);

            //assert
            Assert.AreEqual(expected, actual);
        }      
    }
}
