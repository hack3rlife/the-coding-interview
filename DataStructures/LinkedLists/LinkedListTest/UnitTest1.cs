using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using com.hack3rlife.datastructures;


namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1 : LinkedListBaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);


            //Act
            list.Reverse(base.list.Head);

            //Arrange
        }
    }
}
