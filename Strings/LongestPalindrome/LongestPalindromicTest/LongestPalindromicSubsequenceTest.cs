using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings
{
    [TestClass]
    public class LongestPalindromicSubsequenceTest
    {
        [TestMethod]
        public void GetLengthTest()
        {
            //arrange
            var input = "agbdba";
            var expected = 5;

            //act
            var actual = LongestPalindromicSubsequence.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
