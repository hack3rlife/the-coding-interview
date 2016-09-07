using com.hack3rlife.dynamicprogramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class LongestIncreasingSubsequenceSumTest
    {
        [TestMethod]
        public void GetLongestIncreasingSubsequenceSumTest()
        {
            //arrange
            int[] input = { 0, 6, 1, 3, 8, 4, 6 };           

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 18;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void GetLongestIncreasingSubsequenceSumTest2()
        {
            //arrange
            int[] input = { 20, 6, 1, 3, 8, 4, 6 };

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 18;
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
