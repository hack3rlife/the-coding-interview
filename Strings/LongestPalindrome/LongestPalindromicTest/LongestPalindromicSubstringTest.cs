using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings
{
    [TestClass]
    public class LongestPalindromicSubstringTest
    {
        [TestMethod]
        public void GetLengthTest()
        {
            //arrange
            var input = "banana";
            var expected = 5;

            //act
            var actual = LongestPalindromicSubstring.GetLength(input);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
