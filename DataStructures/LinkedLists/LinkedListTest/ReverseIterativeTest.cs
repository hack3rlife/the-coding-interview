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
    public class ReverseIterativeTest
    {     

        [TestMethod()]
        public void LinkedList_ReverseIterativeTest()
        {
            //arrange
            LinkedList actual = new LinkedList();
            actual.AddLast(1);
            actual.AddLast(2);
            actual.AddLast(3);
            actual.AddLast(4);

            LinkedList expected = new LinkedList();
            expected.AddFirst(1);
            expected.AddFirst(2);
            expected.AddFirst(3);
            expected.AddFirst(4);

            //act
            actual.ReverseIterative();

            //arrange
            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }
    }
}