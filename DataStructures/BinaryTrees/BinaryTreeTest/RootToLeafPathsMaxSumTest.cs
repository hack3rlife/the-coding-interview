using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.binarytree;

namespace BinaryTreeTest
{
    [TestClass]
    public class RootToLeafPathsMaxSumTest
    {
        [TestMethod]
        public void RootToLeafPathsMaxSumTestPass()
        {
            //Arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(10);
            tree.Root.Left = new BinaryTreeNode<int>(-2);
            tree.Root.Left.Left = new BinaryTreeNode<int>(8);
            tree.Root.Left.Right = new BinaryTreeNode<int>(-4);          

            tree.Root.Right = new BinaryTreeNode<int>(7);

            tree.Display(true);

            //Act
            int actual = 0;
            tree.RootToLeafPathsMaxSum(tree.Root, 0, ref actual);
            int expected = 17;

            //Assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
