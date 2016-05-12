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
    public class RemoveUnitTest
    {
        [TestMethod()]
        public void LinkedList_RemoveTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(3);
            list.Display();
            list.AddLast(4);
            list.Display();

            //act
            list.Remove(2);
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 3);
        }

        [TestMethod()]
        public void LinkedList_RemoveAllSameValueTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(1);
            list.Display();
            list.AddLast(1);
            list.Display();
            list.AddLast(1);
            list.Display();

            //act
            list.Remove(1);
            list.Display();
                
            //assert
            Assert.IsTrue(list.Count == 3);
        }

        [TestMethod()]
        public void LinkedList_RemoveTwoDuplicatesTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(3);
            list.Display();

            //act
            list.Remove(2);
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 3);
        }

        [TestMethod()]
        public void LinkedList_RemoveThreeDuplicatesTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(3);
            list.Display();

            //act
            list.Remove(2);
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 4);
        }

        [TestMethod()]
        public void LinkedList_RemoveValueOnHeadsTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(3);
            list.Display();

            //act
            list.Remove(1);
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 4);
        }

        [TestMethod()]
        public void LinkedList_RemoveValueOnTailsTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(3);
            list.Display();

            //act
            list.Remove(3);
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 4);
        }

        [TestMethod()]
        public void LinkedList_RemoveEmptyListTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();

            //act
            list.Remove(1);
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 0);
        }
    }
}