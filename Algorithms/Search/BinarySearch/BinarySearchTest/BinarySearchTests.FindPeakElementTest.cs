using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.tests
{
    [TestClass()]
    public class FindPeakElementTest
    {
        [TestMethod()]
        public void BinarySearch_FindPeakElement_Test()
        {
            //arrange
            var input = new int[] { 10, 20, 15, 2, 23, 90, 67 };

            //assert
            var actual = BinarySearch.FindPeakElement(input);

            //assert
            var expected = 1;

            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod()]
        public void BinarySearch_FindPeakElement_LastElement_Test()
        {
            //arrange
            var input = new int[] { 10, 20, 30, 40, 50 };

            //assert
            var actual = BinarySearch.FindPeakElement(input);

            //assert
            var expected = 4;

            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod()]
        public void BinarySearch_FindPeakElement_FirstElement_Test()
        {
            //arrange
            var input = new int[] { 100, 80, 60, 50, 20 };

            //assert
            var actual = BinarySearch.FindPeakElement(input);

            //assert
            var expected = 0;

            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod()]
        public void BinarySearch_FindPeakElement_AllSame_Test()
        {
            //arrange
            var input = new int[] { 10, 10, 10, 10, 10 };

            //assert
            var actual = BinarySearch.FindPeakElement(input);

            //assert
            var expected = 4;

            Assert.AreEqual<int>(expected, actual);
        }
    }
}