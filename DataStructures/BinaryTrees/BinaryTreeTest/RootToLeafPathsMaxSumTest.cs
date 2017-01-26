using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class RootToLeafPathsMaxSumTest
    {
        [TestMethod]
        public void BinaryTree_RootToLeafPathsMaxSum_Test()
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
            var actual = tree.MaxPathSum(tree.Root, 0);
            int expected = 17;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
