using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hackerlife.strings;

namespace WildCardMatchTest
{
    [TestClass]
    public class WildCardMatchTest
    {
        [TestMethod]
        public void IsMatchTestPass()
        {
            // Arrange
            string input = "geeks";
            string wildcard = "g*ks";

            // Act
            bool condition = WildCardMatch.IsMatch(input, wildcard);

            // Assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void IsMatchTestFail()
        {
            // Arrange
            string input = "abcd";
            string wildcard = "abc*c?d";

            // Act
            bool condition = WildCardMatch.IsMatch(input, wildcard);

            // Assert
            Assert.IsTrue(condition);
        }
    }
}
