using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass()]
    public class KnapsackProblemTest
    {
        [TestMethod()]
        public void KnapsackProblem_Get_Test()
        {
            //arrange
            int W = 7;
            int[] weigths = new int[] { 1, 3, 4, 5 };
            int[] values = new int[] { 1, 4, 5, 7 };

            //act
            var actualResult = KnapsackProblem.Get(W, weigths, values, values.Length);

            //assert
            var expectedResult = 9;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
} 