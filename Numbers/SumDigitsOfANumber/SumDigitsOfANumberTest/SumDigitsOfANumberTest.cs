using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace com.hack3rlife.numbers.test
{
    [TestClass]
    public class SumDigitsOfANumberTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void SumDigitsOfANumber_SumDigits_Test()
        {
            //arrange
            var input = (int)TestContext.DataRow["input"];
            var expected = (int)TestContext.DataRow["sum"];

            //act
            int actual = SumDigitsOfANumber.SumDigits(input);

            //assert
             Assert.AreEqual(expected, actual);
        }
    }
}
