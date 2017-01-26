using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTreeAddPass()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();

            //act
            bt.Root = new BinaryTreeNode<int>(1);
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);

            //assert
            Assert.AreEqual(1, bt.Root.Value);
            Assert.AreEqual(2, bt.Root.Left.Value);
            Assert.AreEqual(3, bt.Root.Right.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void LeftRigthToDownRightRepresentationTest()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Root = new BinaryTreeNode<int>(1);
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);

            bt.Root.Right.Left = new BinaryTreeNode<int>(4);
            bt.Root.Right.Right = new BinaryTreeNode<int>(5);

            bt.Root.Right.Left.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right.Left = new BinaryTreeNode<int>(7);
            bt.Root.Right.Right.Right = new BinaryTreeNode<int>(8);

            bt.Display(true);
            //act
            bt.LeftRigthToDownRightRepresentation(bt.Root);
            bt.Display(false);
            //assert      

            Assert.IsNotNull(bt);
        }
    }
}
