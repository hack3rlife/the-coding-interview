using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.binarytree;

namespace BinaryTreeTest
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void BinaryTreeAddPass()
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

        [TestMethod]
        public void LeftRigthToDownRightRepresentationTest()
        {
            //Arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Root = new BinaryTreeNode<int>(1);
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);

            bt.Root.Right.Left = new BinaryTreeNode<int>(4);
            bt.Root.Right.Right = new BinaryTreeNode<int>(5);

            bt.Root.Right.Left.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right.Left = new BinaryTreeNode<int>(7);
            bt.Root.Right.Right.Right = new BinaryTreeNode<int>(8);

            bt.Display(true);
            //Act
            bt.LeftRigthToDownRightRepresentation(bt.Root);
            bt.Display(false);
            //Assert      

            Assert.IsNotNull(bt);
        }
    }
}
