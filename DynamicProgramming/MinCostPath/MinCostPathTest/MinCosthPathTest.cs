using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinCostPath;

namespace MinCostPathTest
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

            var result = MinCosthPath.Get(matrix);

            // assert
            Assert.AreEqual(12, result);
        }
    }
}
