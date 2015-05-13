using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace IsPalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void IsPalindromeTestPass()
        {
            //Arrange
            string input = "radar";

            //Act
            bool condition = Palindrome.IsPalindrome(input);

            //Assert 
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void IsPalindromeTestFail()
        {
            //Arrange
            string input = "radars";

            //Act
            bool condition = Palindrome.IsPalindrome(input);

            //Assert 
            Assert.IsFalse(condition);
        }

        [TestMethod]
        public void LonguestPalindromeTest()
        {
            //Arrange
            string input = "forgeeksskeegfor";
            string expected = "geeksskeeg";

            //Act
            string actual = Palindrome.LonguestPalindrome(input.ToCharArray(0, input.Length - 1));

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
