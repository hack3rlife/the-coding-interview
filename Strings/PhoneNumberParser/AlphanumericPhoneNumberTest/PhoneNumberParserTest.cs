using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class PhoneNumberParserTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void PhoneNumberParser_GetPhoneNumber_Test()
        {
            // arrange
            var number = TestContext.DataRow["input"].ToString();
            var expected = TestContext.DataRow["output"].ToString();

            // act
            var actual = PhoneNumberParser.GetPhoneNumber(number);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
