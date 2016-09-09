using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class MergeRecursiveTest
    {
        public LinkedList<int> list { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            list = new LinkedList<int>();
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
        public void LinkedLists_MergeRecursiveTest()
        {
            //act
           var list1 = new LinkedList<int>();
            list1.AddLast(10);
            list1.AddLast(30);
            list1.AddLast(50);
            list1.AddLast(70);
            list1.AddLast(90);
            list1.Display();

            var list2= new LinkedList<int>();
            list2.AddLast(20);
            list2.AddLast(40);
            list2.AddLast(60);
            list2.AddLast(80);
            list2.Display();

            //arrange
            var actual  = list1.Head.MergeRecursive(list2.Head);

            //assert
            //CollectionAssert.AreEqual(list.Head, actual);
        }
    }
}