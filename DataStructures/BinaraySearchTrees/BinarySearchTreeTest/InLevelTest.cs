using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class InLevelTest
    {
        [TestMethod]
        public void BinarySearchTree_InLevel_Test()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>
            {
                1,
                2,
                3,
                4,
                5,
                6
            };
            bst.Display();

            //act
            var actual = bst.InLevel(bst.Root);

            //assert
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
