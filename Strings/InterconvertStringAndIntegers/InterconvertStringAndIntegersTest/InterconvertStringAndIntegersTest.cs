using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class InterconvertStringAndIntegersTest
    {
        [TestMethod]
        public void InterconvertStringAndIntegers_ToString_Test()
        {
            //arrange
            var input = 12345;
            var expected = "12345";

            //act
           var actual = InterconvertStringAndIntegers.ToString(input);

            //assert 
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
