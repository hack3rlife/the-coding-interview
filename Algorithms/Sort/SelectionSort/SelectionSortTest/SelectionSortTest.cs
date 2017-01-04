using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting.test
{
    [TestClass]
    public class SelectionSortTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("SelectionSort")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\selection_sort.csv", "selection_sort#csv", DataAccessMethod.Sequential)]
        public void SelectionSort_Sort_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = TestContext.DataRow[1].ToString().Split(new char[] { ' ' });

            //act
            var actual = SelectionSort.Sort(Array.ConvertAll(input, s => int.Parse(s)));

            //assert
            CollectionAssert.AreEqual(Array.ConvertAll(expected, s => int.Parse(s)), actual);
        }
    }
}
