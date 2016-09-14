using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass]
    public class CountOccurrencesTest
    {
        [TestMethod]
        public void CountOccurrencesTestNoError()
        {
            // arrange
            var expected = 4;

            var input = new int[] { 1, 1, 2, 2, 2, 2, 3 };
            var k = 2;

            // act
            var actual = BinarySearch.Count(input, k);

            // assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void CountOccurrencesTestZeroOccurrence()
        {
            // arrange
            var expected = 0;

            var input = new int[] { 1, 1, 2, 2, 2, 2, 3 };
            var k = 4;

            // act
            var actual = BinarySearch.Count(input, k);

            // assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void CountOccurrencesTestAll()
        {
            // arrange
            var expected = 5;

            var input = new int[] { 1, 1, 1, 1, 1 };
            var k = 1;

            // act
            var actual = BinarySearch.Count(input, k);

            // assert
            Assert.AreEqual<int>(expected, actual);
        }

    }
}
