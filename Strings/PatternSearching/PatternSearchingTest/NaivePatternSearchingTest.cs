using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace PatternSearchingTest
{
    [TestClass]
    public class NaivePatternSearchingTest
    {
        [TestMethod]
        public void SearchTest()
        {
            //arrange
            string input = "this is a test";
            string pattern = "test";
            int expected = 10;

            //act
            int actual = NaivePatternSearching.Search(input, pattern);

            //assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
