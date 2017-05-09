using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.Test
{
    [TestClass()]
    public class MinHeapTest
    {
        [TestMethod()]
        [TestCategory("Heap")]
        public void MinHeap_AddTest()
        {
            //arrange
            MinHeap<int> heap = new MinHeap<int>();

            //act
            heap.Add(3);
            heap.Add(2);
            heap.Add(1);

            //assert
            CollectionAssert.AreEqual(new List<int>() { 1, 3, 2 }, heap.Items.ToList());
        }

        [TestMethod()]
        [TestCategory("Heap")]
        public void MinHeap_ExtractTest()
        {
            //arrange
            int actualMin = int.MaxValue;

            MinHeap<int> heap = new MinHeap<int>();
            heap.Add(3);
            heap.Add(5);
            heap.Add(10);
            heap.Add(1);
            heap.Add(8);


            //act && assert
            actualMin = heap.Extract();
            Assert.AreEqual(1, actualMin);

            actualMin = heap.Extract();
            Assert.AreEqual(3, actualMin);

            actualMin = heap.Extract();
            Assert.AreEqual(5, actualMin);

            //assert
        }

        [TestMethod()]
        [TestCategory("Heap")]
        public void MinHeap_Constructor_Test()
        {
            Assert.Fail();
        }
    }
}