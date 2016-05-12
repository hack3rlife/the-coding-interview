using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms
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
            var bst = expected.ToBinarySearchTree(0, expected.Length-1);
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
