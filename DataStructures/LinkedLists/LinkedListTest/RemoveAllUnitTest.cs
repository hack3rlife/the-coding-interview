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
    public class RemoveAllUnitTest
    {
        [TestMethod()]
        public void LinkedList_RemvoveAllTest()
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
            list.Head = list.RemoveAll(3, list.Head);
            list.Display();

            //assert
            //TODO: Add assertion here
        }

        [TestMethod()]
        public void LinkedList_RemvoveAllTwoDuplicatesTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(3);
            list.Display();
            list.AddLast(3);
            list.Display();
            list.AddLast(4);
            list.Display();
            list.AddLast(5);
            list.Display();

            //act
            list.Head = list.RemoveAll(3, list.Head);
            list.Display();

            //assert
            //TODO: Add assertion here
        }

        [TestMethod()]
        public void LinkedList_RemvoveAllDuplicatesTest()
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
            list.Head = list.RemoveAll(1, list.Head);
            list.Display();

            //assert
            //TODO: Add assertion here
        }

        [TestMethod()]
        public void LinkedList_RemvoveAllHeadAndTailTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();
            list.AddLast(3);
            list.Display();
            list.AddLast(1);
            list.Display();

            //act
            list.Head = list.RemoveAll(1, list.Head);
            list.Display();

            //assert
            //TODO: Add assertion here
        }
    }
}