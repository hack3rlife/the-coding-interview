using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays
{
    [TestClass]
    public class ArrayToBinarySearchTreeTest
    {
        [TestMethod]
        public void ArrayToBinarySearchTreeTestPass()
        {
            //Arrange
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };

            //Act
            var bst = expected.ToBinarySearchTree(0, expected.Length-1);
            bst.Display();

            //Assert
            int i = 0;
            foreach (var actual in bst.InOrderEnumerable)
            {
                Assert.AreEqual<int>(expected[i++], actual);
            }
        }
    }
}
