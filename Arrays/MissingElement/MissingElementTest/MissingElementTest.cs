using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass]
    public class MissingElementTest
    {
        [TestMethod]
        public void MissingElement_Find_Test()
        {
            //arrange
            int[] input = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //act
            int actual = MissingElement.Find(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MissingElement_FindXOr_Test()
        {
            //arrange
            int[] input = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            int expected = 5;

            //act
            int actual = MissingElement.FindXOr(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
