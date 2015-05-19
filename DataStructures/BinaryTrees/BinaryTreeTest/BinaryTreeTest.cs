using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.binarytree;

namespace BinaryTreeTest
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            BinaryTree<int> bt = new BinaryTree<int>();
           
            //Act
            bt.Root = new BinaryTreeNode<int>(1);
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);

            //Assert
            Assert.AreEqual(1, bt.Root.Value);
            Assert.AreEqual(2, bt.Root.Left.Value);
            Assert.AreEqual(3, bt.Root.Right.Value);

        }
    }
}
