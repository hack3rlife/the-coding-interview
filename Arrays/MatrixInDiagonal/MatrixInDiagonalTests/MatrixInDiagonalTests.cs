using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.Tests
{
    [TestClass()]
    public class MatrixInDiagonalTests
    {
        [TestMethod()]
        public void PrintTest()
        {
            int[,] input = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };

            MatrixInDiagonal.Print(input);


        }
    }
}