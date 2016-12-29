using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class LookAndSayTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\look-and-say sequence.csv", "look-and-say sequence#csv", DataAccessMethod.Sequential)]
        public void LookAndSay_GetSequence_Succeed()
        {
            //arrange
            var number = (int)TestContext.DataRow["input"];
            var expected = TestContext.DataRow["output"].ToString();

            //act
            var actual = LookAndSay.GetSequence(number);

            //assert
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
