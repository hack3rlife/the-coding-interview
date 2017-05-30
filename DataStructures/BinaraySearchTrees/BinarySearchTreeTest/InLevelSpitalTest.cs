using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class InLevelSpitalTest
    {
        [TestMethod]
        public void BinarySearchTree_InLevelSpiral_Test()
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
            bst.InLevelSpiral(bst.Root);

            //assert
            //var expected = new List<int>() { 1, 2, 3, 6, 5, 4 };

            //CollectionAssert.AreEqual(actual, expected);
        }
    }
}
