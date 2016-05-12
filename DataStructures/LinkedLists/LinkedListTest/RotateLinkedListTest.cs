using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;

namespace MyLinkedListTest
{
    [TestClass]
    public class RotateMyLinkedListTest
    {
        [TestMethod]
        public void RotateTest()
        {
            LinkedList list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.Display();

            list.Rotate(4);

            list.Display();
        }
    }
}
