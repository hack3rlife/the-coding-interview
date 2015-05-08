using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace SwappingNumbersTest
{
    [TestClass]
    public class SwappingNumbersTest
    {
        [TestMethod]
        public void SwapTest()
        {
            // Arrange
            int a = 10;
            int b = 5;

            int d = 10;
            int e = 5;

            // Act
            SwappingNumbers.BitwiseSwap(ref a, ref b);
            SwappingNumbers.BitwiseSwap(ref d, ref e);

            // Assert
            Assert.AreEqual(a, d);
            Assert.AreEqual(b, e);
            
        }

        [TestMethod]
        public void BitwiseSwapTest()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            SwappingNumbers.BitwiseSwap(ref num1, ref num2);

            // Assert
            Assert.AreEqual(5, num1);
            Assert.AreEqual(10, num2);
        }

        [TestMethod]
        public void ArithmeticSwapTest()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            SwappingNumbers.ArithmeticSwap(ref num1, ref num2);

            // Assert
            Assert.AreEqual(5, num1);
            Assert.AreEqual(10, num2);
        }
    }
}
