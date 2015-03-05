using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class MergeAlternateNodesTest
    {
        [TestMethod]
        public void MergeAlternateNodes()
        {
            LinkedList.LinkedList<int> list1 = new LinkedList.LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            //list1.AddLast(4);
            //list1.AddLast(5);

            LinkedList.LinkedList<int> list2 = new LinkedList.LinkedList<int>();
            list2.AddLast(6);
            list2.AddLast(7);
            list2.AddLast(8);
            list2.AddLast(9);
            list2.AddLast(0);

            list1.MergeAlternateNodes<int>(list2);

            list1.Display();
            list2.Display();
        }
    }
}
