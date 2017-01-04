using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass()]
    public partial class FindPivotTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search_pivoted.csv", "binary_search_pivoted#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_PivotedBinarySearch_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var k = (int)TestContext.DataRow[1];
            var expected = (int)TestContext.DataRow[2];

            //assert
            var actual = BinarySearch.PivotedBinarySearch(Array.ConvertAll(input, s => int.Parse(s)), k);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}