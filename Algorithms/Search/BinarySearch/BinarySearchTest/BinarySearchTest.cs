using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass]
    public class BinarySearchTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search.csv", "binary_search#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_IterativeSearch_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var k = (int)TestContext.DataRow[1];
            var expected = (int)TestContext.DataRow[2];

            //act
            var actual = BinarySearch.Search(Array.ConvertAll(input, s => int.Parse(s)), k);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search.csv", "binary_search#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_RecursiveSearch_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var k = (int)TestContext.DataRow[1];
            var expected = (int)TestContext.DataRow[2];

            //act
            var arr = Array.ConvertAll(input, s => int.Parse(s));
            int actual = BinarySearch.Search(arr, k, 0, arr.Length - 1);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
