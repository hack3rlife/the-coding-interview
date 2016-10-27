using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.binarytree.test
{
    [TestClass]
    public class LowestCommonAncestorTest
    {
        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_RootIsNull()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();

            //act
            var actual = bt.LowestCommonAncestor(null, null, null);

            //assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_LeftIsNull()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);

            bt.Display();

            //act
            var actual = bt.LowestCommonAncestor(bt.Root, null, bt.Root.Right);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Right.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_RightIsNull()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);
            bt.Display();

            //act
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root.Left, null);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Left.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_NoLCA()
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

            bt.Display();

            //act
            var actual = bt.LowestCommonAncestor(bt.Root, new BinaryTreeNode<int>(10), new BinaryTreeNode<int>(11));

            //assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_NoError()
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
            bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            //act
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root.Right.Left, bt.Root.Right.Right);

            //assert
            Assert.IsTrue(actual.Value == 3);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_AllSameNode()
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

            bt.Display();

            //act 
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root, bt.Root);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_LeftIsLCA()
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

            bt.Display();

            //act 
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root.Left.Left, bt.Root.Left.Left);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Left.Left.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_RightIsLCA()
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

            bt.Display();

            //act 
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root.Right.Right, bt.Root.Right.Right);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Right.Right.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_Left_RootIsLCA()
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

            bt.Display();

            //act 
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root.Left.Left, bt.Root.Left);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Left.Value);
        }

        [TestMethod]
        [TestCategory("BinaryTree")]
        public void BinaryTree_LowestComontAncestor_Righ_RootIsLCA()
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

            bt.Display();

            //act 
            var actual = bt.LowestCommonAncestor(bt.Root, bt.Root.Right, bt.Root.Right.Right);

            //assert
            Assert.IsTrue(actual.Value == bt.Root.Right.Value);
        }
    }
}
