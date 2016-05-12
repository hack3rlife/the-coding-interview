using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass]
    public class ReverseRecursiveTest : LinkedListBaseTest
    {
        [TestMethod]
        public void TestMethod1()
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
            actual.ReverseRecursive(actual.Head);

            //arrange
            //CollectionAssert.AreEqual(expected, actual);
        }
    }
}
