using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class BuildLowestNumberTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void LowestNumber_Build_Test()
        {
            //arrange
            string input = TestContext.DataRow["number"].ToString();
            string expected = TestContext.DataRow["result"].ToString();
            string actual = string.Empty;

            int n = (int)TestContext.DataRow["k"];

            //act
            LowestNumber.BuildLowestNumber(input, n, ref actual);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
