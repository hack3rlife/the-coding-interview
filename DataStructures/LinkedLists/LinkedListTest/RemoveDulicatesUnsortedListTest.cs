using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class RemoveDulicatesUnsortedListTest
    {
        [TestMethod()]
        public void LinkedList_RemoveDulicatesUnsorted()
        {

            //arrange
            LinkedList list = new LinkedList();

            list.AddLast(12);
            list.AddLast(11);
            list.AddLast(12);
            list.AddLast(21);
            list.AddLast(41);
            list.AddLast(43);
            list.AddLast(21);
            list.Display();

            //act

            var actualList = list.RemoveDulicatesUnsorted();
            actualList.Display();

            //assert
            LinkedList expectedList = new LinkedList();
            expectedList.AddLast(12);
            expectedList.AddLast(11);
            expectedList.AddLast(21);
            expectedList.AddLast(41);
            expectedList.AddLast(43);
            expectedList.Display();


            CollectionAssert.AreEqual(expectedList.ToArray(), list.ToArray());
        }
    }
}