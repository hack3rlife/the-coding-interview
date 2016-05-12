using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class RemoveLastUnitTest
    {
        [TestMethod]
        public void LinkedList_RemoveFirstVerifyHeadTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(0);
            list.Display();
            list.AddFirst(1);
            list.Display();
            list.AddFirst(2);
            list.Display();
            list.AddFirst(3);
            list.Display();
            list.AddFirst(4);
            list.Display();

            //act
            list.RemoveLast();
            list.Display();

            int expected = 4;
            int actual = list.Head.Value;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_RemoveFirstVerifyTailTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(0);
            list.Display();
            list.AddFirst(1);
            list.Display();
            list.AddFirst(2);
            list.Display();
            list.AddFirst(3);
            list.Display();
            list.AddFirst(4);
            list.Display();

            //act
            list.RemoveLast();
            list.Display();

            int expected = 1;
            int actual = list.Tail.Value;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_RemoveFirstVerifyCountTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(0);
            list.Display();
            list.AddFirst(1);
            list.Display();
            list.AddFirst(2);
            list.Display();
            list.AddFirst(3);
            list.Display();
            list.AddFirst(4);
            list.Display();

            //act
            list.RemoveLast();
            list.Display();

            int expected = 4;
            int actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_RemoveFirstVerifyHeadEqualTailTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(0);
            list.Display();
            list.AddFirst(1);
            list.Display();

            //act
            list.RemoveLast();
            list.Display();

            int expected = list.Tail.Value;
            int actual = list.Head.Value;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_RemoveFirstEmptyListTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(0);
            list.Display();

            //act
            list.RemoveLast();
            list.Display();

            //assert
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.IsTrue(list.Count == 0);
        }
    }
}