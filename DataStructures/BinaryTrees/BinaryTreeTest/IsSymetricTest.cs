using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class IsSymetricTest
    {
        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsSymetricTest_Root_IsNull()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = null;

            //act
            var actual = bt.IsSymetric(bt.Root);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsSymetricTest_False()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(2);
            //level 2
            bt.Root.Left.Left = new BinaryTreeNode<int>(3);
            bt.Root.Left.Right = new BinaryTreeNode<int>(4);

            bt.Root.Right.Left = new BinaryTreeNode<int>(3);
            bt.Root.Right.Right = new BinaryTreeNode<int>(4);

            bt.Display();

            //act
            var actual = bt.IsSymetric(bt.Root);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsSymetricTest_True()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(2);
            //level 2
            bt.Root.Left.Left = new BinaryTreeNode<int>(3);
            bt.Root.Left.Right = new BinaryTreeNode<int>(4);

            bt.Root.Right.Left = new BinaryTreeNode<int>(4);
            bt.Root.Right.Right = new BinaryTreeNode<int>(3);

            bt.Display();

            //act
            var actual = bt.IsSymetric(bt.Root);

            // assert
            Assert.IsTrue(actual);
        }
    }
}