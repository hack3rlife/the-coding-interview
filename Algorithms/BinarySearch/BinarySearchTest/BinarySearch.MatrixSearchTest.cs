using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.tests
{
    [TestClass()]
    public class MatrixSearchTest
    {
        [TestMethod()]
        public void BinarySearch_MatrixSearchTest()
        {
            //arrange
            var marix = new int[,] {
                                        {10, 20, 30, 40},
                                        {15, 25, 35, 45},
                                        {27, 29, 37, 48},
                                        {32, 33, 39, 50}
                                    };

            //act
            var condition = BinarySearch.MatrixSearch(marix, 37);

            //assert
            Assert.IsTrue(condition);
        }
    }
}