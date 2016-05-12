﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class RotateUnitTest
    {
        [TestMethod()]
        public void RotateTest()
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
            list.AddFirst(5);
            list.Display();
            list.AddFirst(6);
            list.Display();

            //act
            list.Rotate(3);
            list.Display();

            //assert
            Assert.IsTrue(list.Head.Value == 3);
            Assert.IsTrue(list.Tail.Value == 4);
        }
    }
}