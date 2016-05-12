using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class AddLastUnitTest
    {
        [TestMethod()]
        public void LinkedList_AddLastVerifyTailTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
            list.AddLast(0);
            list.Display();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();

            //assert
            var expected = 2;
            var actual = list.Tail.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LinkedList_AddLastVerifyHeadTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
            list.AddLast(0);
            list.Display();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();

            //assert
            var expected = 0;
            var actual = list.Head.Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LinkedList_AddLastVerifyCountTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
            list.AddLast(0);
            list.Display();
            list.AddLast(1);
            list.Display();
            list.AddLast(2);
            list.Display();

            //assert
            var expected = 3;
            var actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LinkedList_AddLastVerifyHeadTailEqualTest()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act
            list.AddLast(0);

            //assert
            var expected = list.Head.Value;
            var actual = list.Tail.Value;

            Assert.AreEqual(expected, actual);
        }
    }
}