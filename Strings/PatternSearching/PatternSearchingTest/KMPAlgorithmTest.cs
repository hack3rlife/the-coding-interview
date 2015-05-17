using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace PatternSearchingTest
{
    [TestClass]
    public class KMPAlgorithmTest
    {
        [TestMethod]
        public void SearchTest()
        {
            //Arrange
            string input = "AAAAAAAAAAAAAAAAAB";
            string pattern = "AAAAB";

            //Act
            int actual = KMPAlgorithm.Search(pattern, input);
            int expected = 13;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
