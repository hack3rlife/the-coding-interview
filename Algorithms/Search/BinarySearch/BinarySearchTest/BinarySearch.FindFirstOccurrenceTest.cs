using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass]
    public class FindFirstOccurrenceTest
    {
        [TestMethod]
        public void FindFirstOccurrence_Test()
        {
            // arrange
            var expected = 2;

            var input =  new int[]{ 1, 1, 2, 2, 2, 2, 3 };
            var k = 2;

            // act
            var actual = BinarySearch.FindFirstOccurrence(input, k);

            // assert
            Assert.AreEqual<int>(expected, actual);
        }

    }
}
