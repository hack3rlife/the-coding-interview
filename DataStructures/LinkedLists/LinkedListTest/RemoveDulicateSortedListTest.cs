using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class RemoveDulicateSortedListTest
    {
        [TestMethod()]
        public void LinkedList_RemoveDulicatesSortedList()
        {

            //arrange
            LinkedList list = new LinkedList();

            list.AddLast(11);
            list.AddLast(11);
            list.AddLast(11);
            list.AddLast(21);
            list.AddLast(43);
            list.AddLast(43);
            list.AddLast(60);
            list.Display();

            //act

            var actualList = list.RemoveDuplicatesSorted();
            actualList.Display();

            //assert
            LinkedList expectedList = new LinkedList();
            expectedList.AddLast(11);
            expectedList.AddLast(21);
            expectedList.AddLast(43);
            expectedList.AddLast(60);
            expectedList.Display();


            CollectionAssert.AreEqual(expectedList.ToArray(), list.ToArray());
        }
    }
}