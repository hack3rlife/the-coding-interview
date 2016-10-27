using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.binarytree.test
{
    [TestClass]
    public class RootToLeafPathsMaxSumTest
    {
        [TestMethod]
        public void BinaryTree_RootToLeafPathsMaxSumTestPass_NoError()
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
            int actual = 0;
            tree.RootToLeafPathsMaxSum(tree.Root, 0, ref actual);
            int expected = 17;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
