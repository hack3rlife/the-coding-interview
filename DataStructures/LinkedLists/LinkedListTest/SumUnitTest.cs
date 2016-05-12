using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class SumUnitTest
    {
        [TestMethod()]
        public void LinkedList_SumTest()
        {
            //arrange
            LinkedList a = new LinkedList();
            a.AddLast(3);
            a.Display();
            a.AddLast(1);
            a.Display();
            a.AddLast(4);
            a.Display();

            LinkedList b = new LinkedList();
            b.AddLast(7);
            b.Display();
            b.AddLast(0);
            b.Display();
            b.AddLast(9);
            b.Display();

            //act
            var actual = a.Sum(b);

            //assert            
        }
    }
}