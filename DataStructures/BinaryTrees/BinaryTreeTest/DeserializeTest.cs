using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.binarytree.test
{
    [TestClass()]
    public class DeserializeTest
    {
        [TestMethod()]
        public void BinaryTree_Deserialize_Test()
        {
            // arrange
            var list = new List<int>() { 20, 8, 4, -1, -1, 12, 10, -1, -1, 4, -1, -1, 22, -1, -1 };

            BinaryTree<int> expectedTree = new BinaryTree<int>();
            expectedTree.Root = new BinaryTreeNode<int>(20);
            expectedTree.Root.Left = new BinaryTreeNode<int>(8);
            expectedTree.Root.Right = new BinaryTreeNode<int>(22);

            expectedTree.Root.Left.Left = new BinaryTreeNode<int>(4);
            expectedTree.Root.Left.Right = new BinaryTreeNode<int>(12);

            expectedTree.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            expectedTree.Root.Left.Right.Right = new BinaryTreeNode<int>(4);

            expectedTree.Display();

            // act
            var actualTree = new BinaryTree<int>();
            actualTree.Root = actualTree.Deserialize(list);

            // assert
            AreEqual(expectedTree, actualTree);

        }

        private void AreEqual(BinaryTree<int> expected, BinaryTree<int> actual)
        {
            //expected.InOrder(expected.Root);
            var expectedList = expected.InOderList;

            //actual.InOrder(actual.Root);
            var actualList = actual.InOderList;

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}