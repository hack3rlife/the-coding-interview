using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.numbers.test
{
    [TestClass]
    public class ReverseNumberTest
    {
        [TestMethod]
        public void ReverseNumber_Reverse_Test()
        {
            // arrange
            int input = 1234;

            // act
            int actual = ReverseNumber.Reverse(input);
            int expected = 4321;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
