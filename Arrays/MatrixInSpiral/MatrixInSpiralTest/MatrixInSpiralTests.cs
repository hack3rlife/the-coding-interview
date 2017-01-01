using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class MatrixInSpiralTests
    {
        [TestMethod()]
        public void MatrixInSpiral_Print_NxN_Test()
        {
            // arrange
            int[,] input = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            var expected = "1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10";

            // act
            var actual = MatrixInSpiral.Print(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [Ignore]
        public void MatrixInSpiral_Print_MxN_Test()
        {
            // arrange
            int[,] input = { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 } };

            var expected = "1 2 3 4 5 6 12 18 17 16 15 14 13 7 8 9 10 11";

            // act
            var actual = MatrixInSpiral.Print(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}