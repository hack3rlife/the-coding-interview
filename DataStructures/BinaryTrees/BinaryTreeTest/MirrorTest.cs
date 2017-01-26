using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class MirrorTest
    {
        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_Mirror_Test()
        {
            //Arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Root = new BinaryTreeNode<int>(1);
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);

            bt.Root.Left.Left = new BinaryTreeNode<int>(4);
            bt.Root.Left.Right = new BinaryTreeNode<int>(5);

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);
            var expected = new List<int>() { 7, 3, 6, 1, 5, 2, 4 };

            //Act
            bt.Mirror(bt.Root);
            var actual = bt.InOderList;

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
