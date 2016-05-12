using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class ClearUnitTest
    {
        [TestMethod()]
        public void LinkedList_ClearHeadIsNullTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
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

            list.Clear();
            list.Display();

            //assert
            Assert.IsNull(list.Head);
        }

        [TestMethod()]
        public void LinkedList_ClearTailIsNullTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
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

            list.Clear();
            list.Display();

            //assert
            Assert.IsNull(list.Tail);
        }

        [TestMethod()]
        public void LinkedList_ClearCountIsZeroTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
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

            list.Clear();
            list.Display();

            //assert
            Assert.IsTrue(list.Count == 0);
        }
    }
}