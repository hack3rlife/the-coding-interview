using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings
{
    [TestClass]
    public class InterconvertStringAndIntegersTest
    {
        [TestMethod]
        public void ConvertToStringTest()
        {
            //arrange
            var input = 12345;
            var expected = "12345";

            //act
           var actual = InterconvertStringAndIntegers.ConvertToString(input);

            //assert 
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
