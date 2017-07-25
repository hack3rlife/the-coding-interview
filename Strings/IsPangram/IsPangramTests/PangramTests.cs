using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.Tests
{
    [TestClass()]
    public class PanagramTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\pangrams.csv", "pangrams#csv", DataAccessMethod.Sequential)]
        public void Pangram_IsPangram_PostiveTest()
        {
            //arrange
            string input = TestContext.DataRow["input"].ToString().ToLowerInvariant();

            //act
            bool condition = Pangram.IsPangram(input);

            //assert 
            Assert.IsTrue(condition, string.Format(" {0} is not pangram", input));
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\nopangrams.csv", "nopangrams#csv", DataAccessMethod.Sequential)]
        public void Pangram_IsPangram_NegativeTest()
        {
            //arrange
            string input = TestContext.DataRow["input"].ToString().ToLowerInvariant();

            //act
            bool condition = Pangram.IsPangram(input);

            //assert 
            Assert.IsFalse(condition, string.Format(" {0} is not pangram", input));
        }
    }
}