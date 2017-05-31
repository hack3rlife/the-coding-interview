using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays
{
    [TestClass]
    public class ArrayToBinarySearchTreeTest
    {
        [TestMethod]
        public void ArrayToBinarySearchTreeTestPass()
        {
            //arrange
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };

            //act
            var bst = expected.ToBinarySearchTree();
            bst.Display();

            //assert
            int i = 0;
            foreach (var actual in bst.InOrderEnumerable)
            {
                Assert.AreEqual<int>(expected[i++], actual);
            }
        }
    }
}
