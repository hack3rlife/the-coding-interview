using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.Test
{
    [TestClass()]
    public class MaxHeapTest
    {
        [TestMethod()]
        [TestCategory("Heap")]
        public void MaxHeap_AddTest()
        {
            //arrange
            MaxHeap<int> heap = new MaxHeap<int>();

            //act
            heap.Add(3);
            heap.Add(5);
            heap.Add(10);
            heap.Add(1);
            heap.Add(8);

            //assert
            CollectionAssert.AreEqual(new List<int>() { 10, 8, 5, 1, 3 }, heap.Items.ToList());

        }

        [TestMethod()]
        [TestCategory("Heap")]
        public void MaxHeap_ExtractTest()
        {
            //arrange
            int actualMax = int.MinValue;

            MaxHeap<int> heap = new MaxHeap<int>();
            heap.Add(90);
            heap.Add(30);
            heap.Add(50);
            heap.Add(80);
            heap.Add(70);
            heap.Add(20);
            heap.Add(40);


            //act && assert
            actualMax = heap.Extract();
            Assert.AreEqual(90, actualMax);

            actualMax = heap.Extract();
            Assert.AreEqual(80, actualMax);

            actualMax = heap.Extract();
            Assert.AreEqual(70, actualMax);

            actualMax = heap.Extract();
            Assert.AreEqual(50, actualMax);

            CollectionAssert.AreEqual(new int[] { 40, 20, 30 }, heap.Items.ToList());
        }

        [TestMethod()]
        [TestCategory("Heap")]
        public void MaxHeap_Constructor_Test()
        {
            //arrange
            int[] input = { 4, 2, 10, 16, 3 };

            //act
            MaxHeap<int> heap = new MaxHeap<int>(input);

            //arrange
            CollectionAssert.AreEqual(new int[] { 16, 10, 4, 2, 3 }, heap.Items.ToList());
        }
    }
}