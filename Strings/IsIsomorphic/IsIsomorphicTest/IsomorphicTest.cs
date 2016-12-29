using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass()]
    public class IsomorphicTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\isomorphic_words.csv", "isomorphic_words#csv", DataAccessMethod.Sequential)]
        public void IsIsomorphic_NoError_Test()
        {
            // arrange
            var input1 = TestContext.DataRow[0].ToString();
            var input2 = TestContext.DataRow[1].ToString();

            // act
            var condition = Isomorphic.IsIsomorphic(input1, input2);

            // assert
            Assert.IsTrue(condition);

        }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\noisomorphic_words.csv", "noisomorphic_words#csv", DataAccessMethod.Sequential)]
        public void IsIsomorphic_Error_Test()
        {
            // arrange
            var input1 = TestContext.DataRow[0].ToString();
            var input2 = TestContext.DataRow[1].ToString();

            // act
            var condition = Isomorphic.IsIsomorphic(input1, input2);

            // assert
            Assert.IsFalse(condition);

        }
    }
}