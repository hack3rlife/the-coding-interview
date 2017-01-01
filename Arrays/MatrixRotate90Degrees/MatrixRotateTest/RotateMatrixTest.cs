using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class RotateMatrixTest
    {
        [TestMethod()]
        public void RotateMatrix_NinetyDegrees_MxN_Test()
        {
            // arrange
            int[,] input = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[,] expect = { { 11, 6, 1 }, { 12, 7, 2 }, { 13, 8, 3 }, { 14, 9, 4 }, { 15, 10, 5 } };

            // act
            var actual = RotateMatrix.NinetyDegrees(input);

            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void RotateMatrix_NinetyDegrees_NxN_Test()
        {
            // arrange
            int[,] input = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int[,] expect = { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } };

            // act
            var actual = RotateMatrix.NinetyDegrees(input);

            CollectionAssert.AreEqual(expect, actual);
        }
    }
}