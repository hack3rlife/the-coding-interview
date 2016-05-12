using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace ReverseNumberTest
{
    [TestClass]
    public class ReverseNumberTest
    {
        [TestMethod]
        public void ReverseTest()
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
