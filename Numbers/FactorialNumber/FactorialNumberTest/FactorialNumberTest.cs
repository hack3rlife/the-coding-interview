using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace FactorialNumberTest
{
    [TestClass]
    public class FactorialNumberTest
    {
        [TestMethod]
        public void FactorialTest()
        {
            //Arrange
            int input = 5;

            //Act
            int actual = FactorialNumber.Factorial(input);
            int expected = 120;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
