using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting.test
{
    [TestClass]
    public class InsertionSortTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("InsertionSort")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\insertion_sort.csv", "insertion_sort#csv", DataAccessMethod.Sequential)]
        public void InsertionSort_Sort_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = TestContext.DataRow[1].ToString().Split(new char[] { ' ' });

            //act
            var actual = InsertionSort.Sort(Array.ConvertAll(input, s => int.Parse(s)));

            //assert
            CollectionAssert.AreEqual(Array.ConvertAll(expected, s => int.Parse(s)), actual);
        }
    }
}
