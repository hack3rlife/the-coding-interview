using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.binarysearchtree;

namespace BinarySearchTreeTest
{
    [TestClass]
    //TODO: Move this to a new project called BinaryTreeTest
    public class MirrorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(5);
            bst.Add(4);
            bst.Add(3);
            bst.Add(2);
            bst.Add(1);
            bst.InOrder(bst.Root);

            //Act
            bst.Mirror(bst.Root);
            bst.InOrder(bst.Root);

            var actual = bst.InOrderEnumerable;
            IEnumerable<int> expected = new List<int>() { 5, 4, 3, 2, 1 };

            //Assert
        }
    }
}
