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
            //Arrange
            string input = "My name is Hector";
            string pattern = "name";

            //Act
            int actual = NaivePatternSearching.Search(pattern, input);
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
