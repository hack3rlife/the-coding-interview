using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
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
    }
}