using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumSizeSquare.Test
{
    [TestClass()]
    public class MaximumSizeSquareTest
    {
        [TestMethod()]
        public void MaximumSizeSquare_Print_Test1()
        {
            // arrange
            var input = new int[,]
            {
                { 1,0,1,0,0 },
                { 1,0,1,1,1 },
                { 1,1,1,1,1 },
                { 1,0,0,1,0 },
            };           

            // act
            var actualValue = MaximumSizeSquare.Print(input);

            // assert
            int expectedValue = 4;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void MaximumSizeSquare_Print_Test2()
        {
            // arrange
            var input = new int[,]
            {
                {0, 1, 1, 0, 1},
                {1, 1, 0, 1, 0},
                {0, 1, 1, 1, 0},
                {1, 1, 1, 1, 0},
                {1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0},
            };

            // act
            var actualValue = MaximumSizeSquare.Print(input);

            // assert
            int expectedValue = 9;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}