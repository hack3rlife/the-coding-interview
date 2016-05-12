using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class AddFirstUnitTest
    {
        [TestMethod]
        public void LinkedList_AddFirstVerifyHeadTest()
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

            //assert
            int expected = 4;
            int actual = list.Head.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_AddFirstVerifyTailTest()
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

            //assert
            int expected = 0;
            int actual = list.Tail.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinkedList_AddFirstOneElementVerifyHeadTailEqualTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
            list.AddFirst(0);
            list.Display();            

            //assert
            int actual = list.Head.Value;
            int expected = list.Tail.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFirstVerifyCountTest()
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

            //assert
            int expected = 5;
            int actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}