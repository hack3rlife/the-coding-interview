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
    public class PartitionUnitTest
    {
        [TestMethod()]
        public void PartitionTest()
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
            list.Partition(5);
            list.Display();

            //assert
            Assert.IsTrue(list.Head.Value == 1);
            Assert.IsTrue(list.Tail.Value == 9);
        }
    }
}