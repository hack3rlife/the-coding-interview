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
    public class ContainsUnitTest
    {
        [TestMethod()]
        public void LinkedList_ContainsTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(9);
            list.Display();
            list.AddFirst(1);
            list.Display();
            list.AddFirst(7);
            list.Display();
            list.AddFirst(5);
            list.Display();
            list.AddFirst(4);
            list.Display();
            list.AddFirst(8);
            list.Display();
            list.AddFirst(2);
            list.Display();

            //act
           var condition = list.Contains(5);

            //assert 
            Assert.IsTrue(condition);
        }

        [TestMethod()]
        public void LinkedList_NotContainsTest()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddFirst(9);
            list.Display();
            list.AddFirst(1);
            list.Display();
            list.AddFirst(7);
            list.Display();
            list.AddFirst(5);
            list.Display();
            list.AddFirst(4);
            list.Display();
            list.AddFirst(8);
            list.Display();
            list.AddFirst(2);
            list.Display();

            //act
            var condition = list.Contains(10);

            //assert 
            Assert.IsFalse(condition);
        }
    }
}