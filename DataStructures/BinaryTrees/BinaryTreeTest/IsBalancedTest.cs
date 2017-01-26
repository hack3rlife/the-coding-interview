using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class IsBalancedTest
    {
        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_NoError()
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
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_LeftLeave_NoError()
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

            //act
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_RightLeave_NoError()
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
            bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);
            
            //act
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_NotBalnced()
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
            ////bt.Root.Left.Right = new BinaryTreeNode<int>(5);

            //bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            //bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            //level 3
            bt.Root.Left.Left.Left = new BinaryTreeNode<int>(9);

            //act
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_Left_IsNull_NotBalnced()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            //bt.Root.Left = new BinaryTreeNode<int>(2);
            bt.Root.Right = new BinaryTreeNode<int>(3);
            //level 2
            //bt.Root.Left.Left = new BinaryTreeNode<int>(4);
            //bt.Root.Left.Right = new BinaryTreeNode<int>(5);

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            //level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            //act
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_Right_IsNull_NotBalnced()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = new BinaryTreeNode<int>(1);
            //level 1
            bt.Root.Left = new BinaryTreeNode<int>(2);
            //bt.Root.Right = new BinaryTreeNode<int>(3);
            //level 2
            bt.Root.Left.Left = new BinaryTreeNode<int>(4);
            bt.Root.Left.Right = new BinaryTreeNode<int>(5);

            //bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            //bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            //level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            //act
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        [TestCategory("BinaryTree")]
        public void BinaryTree_IsBalancedTest_Root_IsNull()
        {
            //arrange
            BinaryTree<int> bt = new BinaryTree<int>();
            //root
            bt.Root = null;
            //act
            var actual = bt.IsBalanced(bt.Root);

            // assert
            Assert.IsFalse(actual);
        }
    }
}