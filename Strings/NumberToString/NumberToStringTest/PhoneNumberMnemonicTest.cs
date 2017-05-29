using com.hack3rlife.strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToStringTest
{
    [TestClass]
    public class PhoneNumberMnemonicTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void PhoneNumberMnemonic_Get_UsingCombinations()
        {
            //arrange
            string number = TestContext.DataRow["input"].ToString();
            var expected = TestContext.DataRow["output"].ToString();

            //act
            var actual = PhoneNumberMnemonic.Map(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void PhoneNumberMnemonic_Get_Words()
        {
            //arrange
            string number = TestContext.DataRow["input"].ToString();
            var expected = TestContext.DataRow["output"].ToString();

            //act
            var actual = PhoneNumberMnemonic.Get(number);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
