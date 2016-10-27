using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.binarytree.test
{
    [TestClass()]
    public class FindSuccesorTest
    {
        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_Root_HasRight()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root);

            //assert
            Assert.IsTrue(actual.Value.Equals(6));
        }

        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_LeftChild_WithRigthChild()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root.Left);

            //assert
            Assert.IsTrue(actual.Value.Equals(5));
        }

        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_RightChild_WithRightChild()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root.Right);

            //assert
            Assert.IsTrue(actual.Value.Equals(7));
        }

        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_LeftLeaf_InLeft()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root.Left.Left);

            //assert
            Assert.IsTrue(actual.Value.Equals(2));
        }

        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_RightLeaf_InLeft()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root.Left.Right);

            //assert
            Assert.IsTrue(actual.Value.Equals(1));
        }

        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_LeftLeaf_InRight()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root.Right.Left);

            //assert
            Assert.IsTrue(actual.Value.Equals(3));
        }

        [TestMethod()]
        [TestCategory("BinarySearch")]
        public void BinarySearch_FindSuccesor_RightLeafInRight()
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

            bt.Root.Right.Left = new BinaryTreeNode<int>(6);
            bt.Root.Right.Right = new BinaryTreeNode<int>(7);

            ////level 3
            //bt.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            //bt.Root.Left.Left.Right = new BinaryTreeNode<int>(9);

            //bt.Root.Left.Right.Left = new BinaryTreeNode<int>(10);
            //bt.Root.Left.Right.Right = new BinaryTreeNode<int>(11);

            bt.Display();

            bt.InOrder(bt.Root);

            //act
            var actual = bt.FindSuccesor(bt.Root, bt.Root.Right.Right);

            //assert
            Assert.IsTrue(actual == null);
        }

        
    }
}