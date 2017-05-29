using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class DiameterTest
    {
        [TestMethod()]
        public void BinaryTree_Diameter_Test()
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

            bt.Display(true);

            //act
            var actual = bt.Diameter(bt.Root);
            int expected = 4;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}