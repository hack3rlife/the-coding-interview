using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class PrintMatrixPathsTest
    {
        [TestMethod()]
        public void MatrixPaths_Print_Null_Error_Test()
        {
            // arrange
            int[,] input = null;

            List<string> expectedPaths = null;

            // act
            var actualPaths = MatrixPaths.Print(input);

            // arrange
            Assert.IsNull(actualPaths);
            CollectionAssert.AreEqual(expectedPaths, (List<string>)actualPaths);
        }

        [TestMethod()]
        public void MatrixPaths_Print_Empty_Error_Test()
        {
            // arrange
            int[,] input = new int[,] { };

            List<string> expectedPaths = null;

            // act
            var actualPaths = MatrixPaths.Print(input);

            // arrange
            Assert.IsNull(actualPaths);
            CollectionAssert.AreEqual(expectedPaths, (List<string>)actualPaths);
        }

        [TestMethod()]
        public void MatrixPaths_Print_MxM_NoError_Test()
        {
            // arrange
            int[,] input = new int[3, 3];
            InitializeMatrix(input);

            var expectedPaths = new List<string>()
            {
                 {" 1  4  7  8  9 "},
                 {" 1  4  5  8  9 "},
                 {" 1  4  5  6  9 "},
                 {" 1  2  5  8  9 "},
                 {" 1  2  5  6  9 "},
                 {" 1  2  3  6  9 "},
            };

            // act
            var actualPaths = MatrixPaths.Print(input);

            // arrange
            Assert.AreEqual(6, actualPaths.Count);
            CollectionAssert.AreEqual(expectedPaths, (List<string>)actualPaths);
        }

        [TestMethod()]
        public void MatrixPaths_Print_MxN_NoError_Test()
        {
            // arrange
            int[,] input = new int[3, 4];
            InitializeMatrix(input);

            var expectedPaths = new List<string>()
            {
                { " 1  5  9  10  11  12 "},
                { " 1  5  6  10  11  12 "},
                { " 1  5  6  7  11  12 "},
                { " 1  5  6  7  8  12 "},
                { " 1  2  6  10  11  12 "},
                { " 1  2  6  7  11  12 "},
                { " 1  2  6  7  8  12 "},
                { " 1  2  3  7  11  12 "},
                { " 1  2  3  7  8  12 "},
                { " 1  2  3  4  8  12 " }
            };

            // act
            var actualPaths = MatrixPaths.Print(input);

            // arrange
            Assert.AreEqual(10, actualPaths.Count);
            CollectionAssert.AreEqual(expectedPaths, (List<string>)actualPaths);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        private void InitializeMatrix(int[,] input)
        {
            var count = 1;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    input[i, j] = count++;
                }
            }
        }
    }
}