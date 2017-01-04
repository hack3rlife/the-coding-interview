using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass()]
    public class FindPeakElementTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search_peak.csv", "binary_search_peak#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_FindPeakElement_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = (int)TestContext.DataRow[1];

            //assert
            var actual = BinarySearch.FindPeakElement(Array.ConvertAll(input, s => int.Parse(s)));

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}