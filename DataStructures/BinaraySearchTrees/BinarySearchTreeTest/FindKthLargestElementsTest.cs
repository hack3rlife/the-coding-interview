using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class FindKthLargestElementsTest
    {
        [TestMethod()]
        public void BinarySearchTree_FindKthLargestElementsTest()
        {
            //arrange
            var bst = new BinarySearchTree<int>();
            var r = new Random();
            var actual = new List<int>();
            var expected = new List<int>();
            var inOrderList = new List<int>();
            var k = r.Next(1, 10);

            var count = r.Next(k, 100);

            for (int i = 0; i < count; i++)
            {
                bst.Add(r.Next(count));
            }

            //act
            bst.Root.FindKthLargestElements(k, actual);

            //assert

            foreach (var item in bst.InOrderEnumerable)
            {
                inOrderList.Add(item);
            }

            var index = bst.Count - 1;
            while (k > 0)
            {
                expected.Add(inOrderList[index--]);
                k--;
            }

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}