using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings
{
    [TestClass]
    public class LookAndSayTest
    {
        [TestMethod]
        public void GetSequenceTest()
        {
            //arrange
            var number = 8;
            var expected = "1113213211";

            //act
            var actual = LookAndSay.GetSequence(number);

            //assert
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
