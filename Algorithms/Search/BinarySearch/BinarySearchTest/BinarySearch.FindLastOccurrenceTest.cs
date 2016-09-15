using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass]
    public class FindLastOccurrenceTest
    {
        [TestMethod]
        public void FindFLastOccurrence_Test()
        {
            // arrange
            var expected = 5;

            var input =  new int[]{ 1, 1, 2, 2, 2, 2, 3 };
            var k = 2;

            // act
            var actual = BinarySearch.FindLastOccurrence(input, k);

            // assert
            Assert.AreEqual<int>(expected, actual);
        }

    }
}
