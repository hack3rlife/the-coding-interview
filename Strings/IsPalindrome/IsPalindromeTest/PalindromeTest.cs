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
        public void LonguestPalindromeTestPass()
        {
            //Arrange
            string input = "forgeeksskeegfor";

            //Act
            string actual = Palindrome.LonguestPalindrome(input);
            string expected = "geeksskeeg";

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LonguestPalindromeTestFail()
        {
            //Arrange
            string input = "forgeeksskeegfor";

            //Act
            string actual = Palindrome.LonguestPalindrome(input);
            string expected = "geeksskeegf";

            //Assert 
            Assert.AreNotEqual(expected, actual);
        }
    }
}
