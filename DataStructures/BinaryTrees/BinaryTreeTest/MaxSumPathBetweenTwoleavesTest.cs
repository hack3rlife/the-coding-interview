using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class MaxSumPathBetweenTwoleaves
    {
        [TestMethod()]
        public void MaxSumPathBetweenTwoleaves_Test()
        {
            //arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(-15);
            tree.Root.Left = new BinaryTreeNode<int>(5);
            tree.Root.Right = new BinaryTreeNode<int>(6);
            tree.Root.Left.Left = new BinaryTreeNode<int>(-8);
            tree.Root.Left.Right = new BinaryTreeNode<int>(1);
            tree.Root.Left.Left.Left = new BinaryTreeNode<int>(2);
            tree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
            tree.Root.Right.Left = new BinaryTreeNode<int>(3);
            tree.Root.Right.Right = new BinaryTreeNode<int>(9);
            tree.Root.Right.Right.Right = new BinaryTreeNode<int>(0);
            tree.Root.Right.Right.Right.Left = new BinaryTreeNode<int>(4);
            tree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(-1);
            tree.Root.Right.Right.Right.Right.Left = new BinaryTreeNode<int>(10);

            //act
            var actual = tree.MaxSumPathBetweenTwoleaves(tree.Root);

            //arrange
            Assert.AreEqual(27, actual);
        }
    }
}