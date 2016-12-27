using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class LongestIncreasingSubsequenceSumTest
    {
        [TestMethod]
        public void LongestIncreasingSubsequenceSum_Get_Test()
        {
            //arrange
            int[] input = { 4, 6, 1, 3, 8, 4, 6 };

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 18;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceSum_Get_FirstIsMax()
        {
            //arrange
            int[] input = { 20, 6, 1, 3, 8, 4, 6 };

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 20;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceSum_Get_AllSame()
        {
            //arrange
            int[] input = { 1, 1, 1, 1 };

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 1;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceSum_Get_DecreasingSequence()
        {
            //arrange
            int[] input = { 5, 4, 3, 2, 1 };

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 5;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceSum_Get_FirstAndEnd()
        {
            //arrange
            int[] input = { 1, 0, 0, 2 };

            //act
            var actual = LongestIncreasingSubsequenceSum.Get(input);

            //assert
            var expected = 3;
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
