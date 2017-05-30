using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.hack3rlife.datastructures;

namespace LinkedListTest
{
    [TestClass]
    public class ReverseAlternateNodesAndAppendAtTheEndTest : LinkedListBaseTest
    {
        [TestMethod]
        public void ReverseAndAppend()
        {
            //arrange
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.Display();

            //act
            list.ReverseAlternateNodesAndAppendAtTheEnd();
            list.Display();

            //assert
        }
    }
}
