using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.binarytree;


namespace BinaryTreeTest
{
    [TestClass]
    public class SumOfAllLeaves
    {
        [TestMethod]
        public void SumOfAllLeavesTest()
        {
            //Arrange
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new BinaryTreeNode<int>(20);
            tree.Root.Left = new BinaryTreeNode<int>(9);
            tree.Root.Left.Left = new BinaryTreeNode<int>(5);
            tree.Root.Left.Right = new BinaryTreeNode<int>(12);
            tree.Root.Left.Right.Right = new BinaryTreeNode<int>(15);

            tree.Root.Right = new BinaryTreeNode<int>(49);
            tree.Root.Right.Left = new BinaryTreeNode<int>(23);
            tree.Root.Right.Right = new BinaryTreeNode<int>(52);
            tree.Root.Right.Right.Left = new BinaryTreeNode<int>(50);

            //Act
            int actual = tree.SumOfAllLeaves(tree.Root);
            int expected = 93;

            //Test
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
