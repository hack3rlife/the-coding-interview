using System;
using com.hack3rlife.binarytree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTest
{
    [TestClass]
    public class LowestCommonAncestor
    {
        [TestMethod]
        public void LCATest()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);
            //level 2
            bt.Root.Left.Left = new BinaryTreeNode<int>(4);
            bt.Root.Left.Right = new BinaryTreeNode<int>(5);
            
            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            //level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);
            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.LowestCommonAncestor(bt.Root, bt.Root.Right.Left, bt.Root.Right.Right);
        }
    }
}
