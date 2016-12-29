using com.hack3rlife.strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class PalindromeTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\palindromes.csv", "palindromes#csv", DataAccessMethod.Sequential)]
        public void Palindrome_IsPalindrome_Success()
        {
            //arrange
            string input = TestContext.DataRow["input"].ToString().ToLowerInvariant();

            //act
            bool condition = Palindrome.IsPalindrome(input);

            //assert 
            Assert.IsTrue(condition, string.Format(" {0} is not palindrome", input));
        }

        [TestMethod]
        public void Palindrome_IsPalindrome_Fail()
        {
            //arrange
            string input = "radars";

            //act
            bool condition = Palindrome.IsPalindrome(input);

            //assert 
            Assert.IsFalse(condition);
        }

        [TestMethod]
        public void Palindrome_IsPalindrome_NullString_Fail()
        {
            //arrange

            //act
            bool condition = Palindrome.IsPalindrome(null);

            //assert 
            Assert.IsFalse(condition);
        }

        [TestMethod]
        public void Palindrome_IsPalindrome_EmptyString_Fail()
        {
            //arrange
            string input = "";

            //act
            bool condition = Palindrome.IsPalindrome(input);

            //assert 
            Assert.IsFalse(condition);
        }


            [TestMethod]
        public void Palindrome_IsPalindrome_WhiteSpace_Fail()
        {
            //arrange
            string input = " ";

            //act
            bool condition = Palindrome.IsPalindrome(input);

            //assert 
            Assert.IsFalse(condition);
        }
    }
}
