using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming
{
    [TestClass]
    public class LongestPalindromicSubstringTest
    {
        [TestMethod]
        public void LongestPalindromicSubstring_GetLengthTest()
        {
            //arrange
            var input = "banana";
            var expected = 5;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubstring_GetLengthTest_NoSubstring()
        {
            //arrange
            var input = "abcdef";
            var expected = 1;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubstring_GetLengthTest_AllSame()
        {
            //arrange
            var input = "aaaaa";
            var expected = 5;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubstring_GetLengthTest_PalindromeAtEnd()
        {
            //arrange
            var input = "abcdad";
            var expected = 3;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubstring_GetLengthTest_PalindromeAtBegining()
        {
            //arrange
            var input = "anabcd";
            var expected = 3;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubstring_GetLengthTest_PalindromeAtCenter()
        {
            //arrange
            var input = "abcacde";
            var expected = 3;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
