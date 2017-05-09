using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting
{
    [TestClass]
    public class HeapSortTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("HeapSort")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\heap_sort.csv", "heap_sort#csv", DataAccessMethod.Sequential)]
        public void HeapSort_Sort_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = TestContext.DataRow[1].ToString().Split(new char[] { ' ' });

            //act
            var actual = HeapSort.Sort(Array.ConvertAll(input, s => int.Parse(s)));

            //assert
            CollectionAssert.AreEqual(Array.ConvertAll(expected, s => int.Parse(s)), actual);
        }

        [TestMethod]
        [TestCategory("HeapSort")]
        public void MaxHeapSortTest()
        {
            //arrange
            var input = new int[] { 3, 5, 10, 1, 8 };
            var expected = new int[] { 10, 8, 5, 3, 1 };

            //act
            var actual = HeapSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
