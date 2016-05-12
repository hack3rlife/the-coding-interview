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
            // arrange
            string input = "geeks";
            string wildcard = "g*ks";

            // act
            bool condition = WildCardMatch.IsMatch(input, wildcard);

            // assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void IsMatchTestFail()
        {
            // arrange
            string input = "abcd";
            string wildcard = "abc*c?d";

            // act
            bool condition = WildCardMatch.IsMatch(input, wildcard);

            // assert
            Assert.IsTrue(condition);
        }
    }
}
