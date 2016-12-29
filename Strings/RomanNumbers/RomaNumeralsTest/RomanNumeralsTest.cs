using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class RomanNumeralsTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\roman_numbers.csv", "roman_numbers#csv", DataAccessMethod.Sequential)]
        public void RomanNumerals_NumberToRoman_Test()
        {
            //arrange
            var number = (int)TestContext.DataRow["input"];
            var expected = TestContext.DataRow["output"].ToString();

            //act
            var actual = RomanNumerals.NumberToRoman(number);

            //assert
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
