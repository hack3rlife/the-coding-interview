using System;
using com.hack3rlife.algorithms.searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting.test
{
    [TestClass]
    public class FindMissingElementTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search_missing.csv", "binary_search_missing#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_FindMissingElement_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = (int)TestContext.DataRow[1];

            //act
            int actual = BinarySearch.FindMissingElement(Array.ConvertAll(input, s => int.Parse(s)));

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
