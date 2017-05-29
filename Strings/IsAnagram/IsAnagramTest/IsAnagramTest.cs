using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class IsAnagramTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\valid_anagrams.csv", "valid_anagrams#csv", DataAccessMethod.Sequential)]
        public void IsAnagram_ASCIIBasedSolution_TestPass()
        {
            //arrange
            string source = TestContext.DataRow["string1"].ToString().ToLowerInvariant().Trim().Replace(" ", "");
            string target = TestContext.DataRow["string2"].ToString().ToLowerInvariant().Trim().Replace(" ", "");

            //act
            bool condition = IsAnagram.ASCIIBasedSolution(source, target);

            //assert
            Assert.IsTrue(condition, string.Format("{0} is not anagram of {1}", source, target));
        }

        [TestMethod]
        public void IsAnagram_ASCIIBasedSolution_TestFail()
        {
            //arrange
            string source = "song";
            string target = "home";

            //act
            bool condition = IsAnagram.ASCIIBasedSolution(source, target);

            //assert
            Assert.IsFalse(condition);
        }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\valid_anagrams.csv", "valid_anagrams#csv", DataAccessMethod.Sequential)]
        public void IsAnagram_XOrBasedSolutionTest()
        {
            //arrange
            string source = TestContext.DataRow["string1"].ToString().ToLowerInvariant().Trim().Replace(" ", "");
            string target = TestContext.DataRow["string2"].ToString().ToLowerInvariant().Trim().Replace(" ", "");

            //act
            bool condition = IsAnagram.XOrBasedSolution(source.ToLowerInvariant().Trim(), target.ToLowerInvariant().Trim());

            //assert
            Assert.IsTrue(condition, string.Format("{0} is not anagram of {1}", source, target));
        }
    }
}
