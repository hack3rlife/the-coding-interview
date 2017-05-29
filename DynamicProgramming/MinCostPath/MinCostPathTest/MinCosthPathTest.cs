using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class MinCosthPathTest
    {
        [TestMethod]
        public void MinCosthPath_Get_Test()
        {
            // arrange
            var matrix = new[,]
            {
                { 1, 3, 5, 8 },
                { 4, 2, 1, 7 },
                { 4, 3, 2, 3 }
            };
            // act

            var result = MinCostPath.Get(matrix);

            // assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void MinCosthPath_Get2_Test()
        {
            // arrange
            var matrix = new[,]
            {
                { 1, 2, 3 },
                { 4, 8, 2 },
                { 1, 5, 3 }
            };
            // act

            var result = MinCostPath.Get(matrix);

            // assert
            Assert.AreEqual(8, result);
        }
    }
}
