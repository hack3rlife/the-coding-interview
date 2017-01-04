using System;
using com.hack3rlife.algorithms.sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting.test
{
    [TestClass]
    public class QuickSelectTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("QuickSelect")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\quickselect_sort.csv", "quickselect_sort#csv", DataAccessMethod.Sequential)]
        public void QuickSelect_Sort_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var k = (int)TestContext.DataRow[1];
            var expected = (int)TestContext.DataRow[2];

            var arr = Array.ConvertAll(input, s => int.Parse(s));

            //act
            var actual = QuickSelect.Select(arr, 0, arr.Length-1, k);

            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
