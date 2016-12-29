using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class StringCombinationTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\combinations.csv", "combinations#csv", DataAccessMethod.Sequential)]
        public void StringCombination_Combine_Success()
        {
            // arrange
            var input = TestContext.DataRow["input"].ToString();
            var expected = TestContext.DataRow["output"].ToString();
            // act
            var actual = StringCombination.Get(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
