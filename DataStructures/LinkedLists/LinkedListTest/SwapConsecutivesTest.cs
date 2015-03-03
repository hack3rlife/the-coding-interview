using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class SwapConsecutivesTest
    {
        [TestMethod]
        public void SwapTest()
        {
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.AddLast(70);
            list.Display();
            
            list.SwapConsecutives();
            list.Display();
        }
    }
}
