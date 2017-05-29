using com.hack3rlife.strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternSearchingTest
{
    [TestClass]
    public class KMPAlgorithmTest
    {
        [TestMethod]
        public void KMPAlgorithm_SearchTest()
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
