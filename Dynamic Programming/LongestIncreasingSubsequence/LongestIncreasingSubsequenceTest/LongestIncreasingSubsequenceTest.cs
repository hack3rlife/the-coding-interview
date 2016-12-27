using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class LongestIncreasingSubsequenceTest
    {
        [TestMethod]
        public void LongestIncreasingSubsequence_NoError()
        {
            // arrange
            int[] input = { 3, 4, -1, 0, 6, 2, 3 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 4; // -1 0 2 3
            Assert.AreEqual<int>(expected, actual);

        }

        [TestMethod]
        public void LongestIncreasingSubsequence_AllNegatives()
        {
            // arrange
            int[] input = { -4, -1, -6, -2, -3 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 2;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_AllPositives()
        {
            // arrange
            int[] input = { 3, 4, 1, 0, 6, 2, 3 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 3;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_Zero()
        {
            // arrange
            int[] input = { 0, 0, 0 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 1;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_AllSamePositive()
        {
            // arrange
            int[] input = { 5, 5, 5, 5, 5 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 1;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_AllSameNegative()
        {
            // arrange
            int[] input = { -5, -5, -5, -5, -5 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 1;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_DecreasingOrder()
        {
            // arrange
            int[] input = { 5, 4, 3, 2, 1, 0 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 1;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_IncreasingOrder()
        {
            // arrange
            int[] input = { -2, -1, 0, 1, 2, 3 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 6;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequence_PosNegative()
        {
            // arrange
            int[] input = { -2, 1, 0, -1, 2, -3 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 3;
            Assert.AreEqual<int>(expected, actual);
        }

    }
}
