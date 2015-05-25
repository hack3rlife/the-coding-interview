using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;

namespace LinkedListTest
{
    [TestClass]
    public class ToBinarySearchTreeTest
    {
        [TestMethod]
        public void ToBinarySearchTreeTestPass()
        {
            //Arrange
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(6);
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            LinkedList<int> expected = new LinkedList<int>();
            expected.AddFirst(6);
            expected.AddFirst(5);
            expected.AddFirst(4);
            expected.AddFirst(3);
            expected.AddFirst(2);
            expected.AddFirst(1);

            //Act
            BinarySearchTree<int> bst = list.ToBinarySearchTree<int>(list.Count);
            bst.Display();
           

            //Assert
            foreach (var item in bst.InOrderEnumerable)
            {
                Assert.AreEqual<int>(expected.Head.Value, item);
                expected.Head = expected.Head.Next; 
            }

        }
    }
}
