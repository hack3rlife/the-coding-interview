using System;
using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTests: LinkedListBaseTest
    {
        [TestMethod]
        public void AddFirstTest()
        {
            //Arrange
            LinkedList<int> ll = new LinkedList<int>();

            //Act
            ll.AddFirst(0);
            ll.Display();
            ll.AddFirst(1);
            ll.Display();
            ll.AddFirst(2);
            ll.Display();
            ll.AddFirst(3);
            ll.Display();
            ll.AddFirst(4);
            ll.Display();

            //Assert
            int expected = 4;
            int actual = ll.Tail.Value;

            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void AddLastTest()
        {
            //Arrange
            LinkedList<int> ll = new LinkedList<int>();

            //Act
            ll.AddLast(0);
            ll.Display();
            ll.AddLast(1);
            ll.Display();
            ll.AddLast(2);
            ll.Display();
            ll.AddLast(3);
            ll.Display();
            ll.AddLast(4);
            ll.Display();

            //Assert
            int expected = 4;
            int actual = ll.Head.Value;

            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void RemoveFirst()
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddFirst(0);
            ll.Display();
            ll.AddFirst(1);
            ll.Display();
            ll.AddFirst(2);
            ll.Display();
            ll.AddFirst(3);
            ll.Display();
            ll.AddFirst(4);
            ll.Display();

            ll.RemoveFirst();
            ll.Display();

            int expected = 3;
            int actual = ll.Tail.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}
