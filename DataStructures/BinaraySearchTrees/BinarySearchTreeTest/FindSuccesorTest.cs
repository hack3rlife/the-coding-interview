using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class BinarySearchTreeFindSuccesorTest
    {
        [TestMethod()]
        public void FindSuccesorTest()
        {
            //arrange
            var bst = new BinarySearchTree<int>();
            bst.Add(15);
            bst.Display();
            bst.Add(6);
            bst.Display();
            bst.Add(18);
            bst.Display();
            bst.Add(3);
            bst.Display();
            bst.Add(7);
            bst.Display();
            bst.Add(17);
            bst.Display();
            bst.Add(20);
            bst.Display();
            bst.Add(2);
            bst.Display();
            bst.Add(4);
            bst.Display();
            bst.Add(13);
            bst.Display();
            bst.Add(9);

            bst.InOrder(bst.Root);

            var node = bst.Root.Left.Right.Right;

            //act
            var actual = bst.FindSuccesor(bst.Root, node);

            //assert
            var expected = 15;


            Assert.AreEqual(expected, actual);
        }
    }
}