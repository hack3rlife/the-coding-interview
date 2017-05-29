using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinChange.Test
{
    [TestClass()]
    public class CoinChangeTest
    {
        [TestMethod()]
        public void CoinChange_Recursive_Count_Test()
        {
            //arrange
            int[] coins = { 1, 2, 3 };
            int cents = 5;

            //act
            var actual = CoinChange.Count(coins, cents, coins.Length - 1);

            //assert
            Assert.AreEqual(5, actual);

        }

        [TestMethod()]
        public void CoinChange_DynamicPrograming_CountTest()
        {
            //arrange
            int[] coins = { 1, 2, 3 };
            int cents = 5;

            //act
            var actual = CoinChange.Count(coins, cents);

            //assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod()]
        public void CoinChange_DynamicPrograming_Count2Test()
        {
            //arrange
            int[] coins = { 1, 2, 3 };
            int cents = 5;

            //act
            var actual = CoinChange.Count2(coins, cents);

            //assert
            Assert.AreEqual(5, actual);
        }
    }
}