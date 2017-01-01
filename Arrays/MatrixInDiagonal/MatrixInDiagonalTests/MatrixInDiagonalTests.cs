using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class MatrixInDiagonalTests
    {
        [TestMethod()]
        public void MatrixInDiagonal_Print_Test()
        {
            // arrange
            int[,] input =
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 }
            };

            // act
            var actual = MatrixInDiagonal.Print(input);

            // assert
            int[,] expected =
            {
                { 1, 0, 0, 0 },
                { 6, 2, 0, 0 },
                { 11, 7, 3 ,  0 },
                { 16, 12, 8, 4 },
                { 17, 13, 9, 5 },
                { 18, 14, 10,  0 },
                { 19, 15,  0,  0 },
                { 20,  0,  0,  0 }
            };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}