using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting
{
    [TestClass]
    public class QuickSortTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("QuickSort")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\quick_sort.csv", "quick_sort#csv", DataAccessMethod.Sequential)]
        public void QuickSort_Sort_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = TestContext.DataRow[1].ToString().Split(new char[] { ' ' });
            var actual = Array.ConvertAll(input, s => int.Parse(s));
            //act
            QuickSort.Sort(actual, 0, actual.Length-1);

            //assert
            CollectionAssert.AreEqual(Array.ConvertAll(expected, s => int.Parse(s)), actual);
        }
    }
}
