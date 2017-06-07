using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass()]
    public class NumberOfIslandsTest
    {
        [TestMethod()]
        public void FindTest()
        {
            // arrange
            var input = new int[,]
            {
                {1, 1, 0, 0, 0},
                {0, 1, 0, 0, 1},
                {1, 0, 0, 1, 1},
                {0, 0, 0, 0, 0},
                {1, 0, 1, 0, 1},
            };

            // act
            var actualValue = NumberOfIslands.Find(input);

            // arrange
            var expectedValue = 5;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void NumberOfIslands_Find_Test()
        {
            // arrange
            var input = new int[,]
            {
                {0, 0, 1, 1, 0},
                {0, 1, 1, 0, 0},
                {0, 0, 0, 0, 0},
                {1, 1, 0, 0, 0},
                {1, 0, 0, 0, 1},
            };

            // act
            var actualValue = NumberOfIslands.Find(input);

            // arrange
            var expectedValue = 3;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

