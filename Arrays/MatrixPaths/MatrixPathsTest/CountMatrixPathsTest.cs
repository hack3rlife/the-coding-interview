using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.Test
{
    [TestClass()]
    public class CountMatrixPathsTest
    {
        [TestMethod()]
        public void MatrixPaths_Count_Null_Test()
        {
            // arrange
            int[,] input = null;

            // act
            var actual = MatrixPaths.Count(input);

            // arrange
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MatrixPaths_Count_Empty_Test()
        {
            // arrange
            int[,] input = new int[,] { };

            // act
            var actual = MatrixPaths.Count(input);

            // arrange
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MatrixPaths_Count_MxM_NoError_Test()
        {
            // arrange
            int[,] input = new int[3, 3];

            // act
            var actual = MatrixPaths.Count(input);

            // arrange
            var expected = 6;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MatrixPaths_Count_MxN_NoError_Test()
        {
            // arrange
            int[,] input = new int[3, 4];

            // act
            var actual = MatrixPaths.Count(input);

            // arrange
            var expected = 10;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MatrixPaths_Count_NxM_NoError_Test()
        {
            // arrange
            int[,] input = new int[4, 3];

            // act
            var actual = MatrixPaths.Count(input);

            // arrange
            var expected = 10;
            Assert.AreEqual(expected, actual);

        }
    }
}