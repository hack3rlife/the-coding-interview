using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class LongestPalindromicSubsequenceTest
    {
        [TestMethod]
        public void LongestPalindromicSubsequence_GetLengthTest()
        {
            //arrange
            var input = "agbdba";
            var expected = 5;

            //act
            var actual = LongestPalindromicSubsequence.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubsequence_GetLengthTest_MultipleSubsequences()
        {
            //arrange
            var input = "alfalfa";
            var expected = 5;

            //act
            var actual = LongestPalindromicSubsequence.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubsequence_GetLengthTest_NoSubsequence()
        {
            //arrange
            var input = "abcdef";
            var expected = 1;

            //act
            var actual = LongestPalindromicSubsequence.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubsequence_GetLengthTest_AllSame()
        {
            //arrange
            var input = "aaaaaaaaaa";
            var expected = 10;

            //act
            var actual = LongestPalindromicSubsequence.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
