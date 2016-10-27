using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class IsBinarySearchTest
    {
        [TestMethod]
        public void IsBinarySearchTestPass()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(4);
            bst.Add(2);
            bst.Add(5);
            bst.Add(1);
            bst.Add(3);
            bst.Display();

            //act
            bool condition = true; // bst.IsBinarySearchTree(bst.Root);

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
