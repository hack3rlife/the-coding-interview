using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLinkedListTest
{
    [TestClass]
    public class SwapConsecutivesTest
    {
        [TestMethod]
        public void SwapTest()
        {
            LinkedList list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.Display();

            list.SwapConsecutives();
            list.Display();
        }
    }
}
