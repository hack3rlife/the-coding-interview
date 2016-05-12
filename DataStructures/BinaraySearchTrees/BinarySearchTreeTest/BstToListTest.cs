using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System.Collections.Generic;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class BstToListTest
    {
        [TestMethod]
        public void BstToListTestPass()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(3);
            bst.Add(2);
            bst.Add(4);
            bst.Add(1);
            bst.Add(5);
            bst.Add(6);

            //act
            var actual = bst.ToList();
            var expected = new List<int>() { 3, 2, 4, 1, 5, 6 };

            //assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.IsTrue(expected[i] == actual[i]);
            }
        }
    }
}
