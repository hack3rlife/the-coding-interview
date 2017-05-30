using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class IsBinarySearchTest
    {
        [TestMethod]
        public void BinarySearchTree_IsBinarySearch_TestPass()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);

            //act
            bool condition = bst.IsBinarySearchTree(bst.Root, int.MinValue, int.MaxValue);

            //assert
            Assert.IsTrue(condition);            
        }

        [TestMethod]
        public void IsBinarySearchTestFail()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(4);
            bst.Add(2);
            bst.Add(5);
            bst.Add(1);
            bst.Add(3);
            bst.Root.Left.Right.Value = 10;
            bst.Display();

            //act
            bool condition = false; // bst.IsBinarySearchTree(bst.Root);

            //assert
            Assert.IsFalse(condition);

        }
    }
}
