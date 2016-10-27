using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class AddTest
    {
        [TestMethod]
        [Description("Test counter is increased properly")]
        public void BinarySearchTree_Add_NoError()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            Random r = new Random();
            int count = r.Next(10);

            for (int i = 0; i < count; i++)
            {
                bst.Add(r.Next(count));
            }

            //assert
            bst.Display();
            Assert.AreEqual(count, bst.Count);
        }

        [TestMethod]
        [Description("Test elements are added to the left tof the BST")]
        public void BinarySearchTree_Add_Left()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(3);
            bst.Add(2);
            bst.Add(1);
            bst.Display();

            //assert
            var exected = 1;
            var actual = bst.Root.Left.Left.Value;
            Assert.AreEqual(exected, actual);
        }

        [TestMethod]
        [Description("Test elements are added to the right tof the BST")]
        public void BinarySearchTree_Add_Right()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(1);
            bst.Add(2);
            bst.Add(3);
            bst.Display();

            //assert
            var exected = 3;
            var actual = bst.Root.Right.Right.Value;
            Assert.AreEqual(exected, actual);
        }

        [TestMethod]
        [Description("Test elements are added to the right tof the BST")]
        public void BinarySearchTree_Add_VerifyBstProperty()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(2);
            bst.Add(3);
            bst.Add(1);
            bst.Display();

            //assert           
            Assert.AreEqual(2, bst.Root.Value);
            Assert.AreEqual(3, bst.Root.Right.Value);
            Assert.AreEqual(1, bst.Root.Left.Value);
        }

        [TestMethod]
        [Description("Verifies that adding values with the same value being inserted on the right")]
        public void BinarySearchTree_Add_AllSameValues()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            bst.Add(1);
            bst.Add(1);
            bst.Add(1);
            bst.Display();

            //assert           
            Assert.AreEqual(1, bst.Root.Value);
            Assert.AreEqual(1, bst.Root.Right.Value);
            Assert.AreEqual(1, bst.Root.Right.Right.Value);
        }       
    }
}