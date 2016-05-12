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
            //arrange
            string input = "AAAAAAAAAAAAAAAAAB";
            string pattern = "AAAAB";

            //act
            int actual = KMPAlgorithm.Search(pattern, input);
            int expected = 13;

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
