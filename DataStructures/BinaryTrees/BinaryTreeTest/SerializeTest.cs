using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.binarytree.test
{
    [TestClass()]
    public class SerializeTest
    {
        [TestMethod()]
        public void BinaryTree_Serialize_Test()
        {
            // arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Root = new BinaryTreeNode<int>(20);
            bt.Root.Left = new BinaryTreeNode<int>(8);
            bt.Root.Right = new BinaryTreeNode<int>(22);

            bt.Root.Left.Left = new BinaryTreeNode<int>(4);
            bt.Root.Left.Right = new BinaryTreeNode<int>(12);

            bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            bt.Root.Left.Right.Right = new BinaryTreeNode<int>(4);

            bt.Display();

            // act
            var actual = new List<int>();
            bt.Serialize(bt.Root, actual);
            var actualTree = bt.Deserialize(actual);

            // assert
            var expected = new List<int>() { 20, 8, 4, -1, -1, 12, 10, -1, -1, 4, -1, -1, 22, -1, -1 };
            CollectionAssert.AreEqual(expected, actual);            
        }
    }
}