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
            // Arrange
            int input = 1234;

            // Act
            int actual = ReverseNumber.Reverse(input);
            int expected = 4321;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
