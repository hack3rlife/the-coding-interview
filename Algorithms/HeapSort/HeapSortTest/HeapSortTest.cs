using com.hack3rlife.heapsort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.heapsortest
{
    [TestClass]
    public class HeapSortTest
    {
        [TestMethod]
        public void HeapSort_Sort()
        {
            //Arange
            int[] input = { 6, 5, 3, 1, 8, 7, 2, 4 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //act
            HeapSort heapsort = new HeapSort();
            var actual = heapsort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
