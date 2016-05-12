using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class FindKthTest
{
        public LinkedList list { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.AddLast(70);
            list.AddLast(80);
            list.AddLast(90);
            list.Display();
        }

        [TestMethod()]
        public void LinkedList_FindKthTest()
        {
            //arrange
            var expected = 70;

            //act
            var actual = list.FindKth(3);

            //assert
            Assert.AreEqual(expected, actual.Value);
        }

        [TestMethod()]
        public void LinkedList_FindKthZeroTest()
        {
            //arrange
            //var expected = null;

            //act
            var actual = list.FindKth(0);

            //assert
            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void LinkedList_FindKthFirstElementTest()
        {
            //arrange
            var expected = 90;

            //act
            var actual = list.FindKth(1);

            //assert
            Assert.AreEqual(expected, actual.Value);
        }

        [TestMethod()]
        public void LinkedList_FindKthLastElementTest()
        {
            //arrange
            var expected = 10;

            //act
            var actual = list.FindKth(9);

            //assert
            Assert.AreEqual(expected, actual.Value);
        }

        [TestMethod()]
        public void LinkedList_FindKthNotInListTest()
        {
            //arrange
            //var expected = null;

            //act
            var actual = list.FindKth(10);

            //assert
            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void LinkedList_FindKthNullListTest()
        {
            //arrange
            list.Clear();

            //act
            var actual = list.FindKth(10);

            //assert
            Assert.IsNull(actual);
        }
    }
}