using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class MaxSumRootToLeafTest
    {
        [TestMethod]
        public void BinaryTree_MaxSumRootToLeaf_Test()
        {
            //arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Root = new BinaryTreeNode<int>(10);
            tree.Root.Left = new BinaryTreeNode<int>(-2);
            tree.Root.Left.Left = new BinaryTreeNode<int>(8);
            tree.Root.Left.Right = new BinaryTreeNode<int>(-4);

            tree.Root.Right = new BinaryTreeNode<int>(7);

            tree.Display(true);

            //act
            var actual = tree.MaxSumRootToLeaf(tree.Root);
            int expected = 17;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void BinaryTree_MaxSumRootToLeaf2_Test()
        {
            //arrnge
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);
            //level 2
            bt.Root.Left.Left = new BinaryTreeNode<int>(4);
            bt.Root.Left.Right = new BinaryTreeNode<int>(5);

            //bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(6);

            ////level 3
            bt.Root.Left.Left.Left = new BinaryTreeNode<int>(7);
            bt.Root.Left.Left.Right = new BinaryTreeNode<int>(8);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            bt.Root.Left.Right.Right = new BinaryTreeNode<int>(9);

            bt.Display(true);

            //act
            var actual = bt.MaxSumRootToLeaf(bt.Root);
            int expected = 17;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
