using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace IsPalindromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void IsPalindrome()
        {
            //arrange
            string input = "radar";

            //act
            bool condition = Palindrome.IsPalindrome(input);

            //assert 
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void IsPalindromeTestFail()
        {
            //arrange
            string input = "radars";

            //act
            bool condition = Palindrome.IsPalindrome(input);

            //assert 
            Assert.IsFalse(condition);
        }     
    }
}
