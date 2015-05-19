using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.binarysearchtree;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class IsBinarySearchTest
    {
        [TestMethod]
        public void IsBinarySearchTestPass()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(4);
            bst.Add(2);
            bst.Add(5);
            bst.Add(1);
            bst.Add(3);
            bst.Display();

            //Act
            bool condition = bst.IsBinarySearchTree(bst.Root);

            //Assert
            Assert.IsTrue(condition);            
        }

        [TestMethod]
        public void IsBinarySearchTestFail()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(4);
            bst.Add(2);
            bst.Add(5);
            bst.Add(1);
            bst.Add(3);
            bst.Root.Left.Right.Value = 10;
            bst.Display();

            //Act
            bool condition = bst.IsBinarySearchTree(bst.Root);

            //Assert
            Assert.IsFalse(condition);

        }
    }
}
