using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class MergeAlternateNodesTest
    {
        [TestMethod]
        public void MergeAlternateNodes()
        {
            LinkedList list1 = new LinkedList();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            //list1.AddLast(4);
            //list1.AddLast(5);

            LinkedList list2 = new LinkedList();
            list2.AddLast(6);
            list2.AddLast(7);
            list2.AddLast(8);
            list2.AddLast(9);
            list2.AddLast(0);

            list1.MergeAlternateNodes(list2);

            list1.Display();
            list2.Display();
        }
    }
}
