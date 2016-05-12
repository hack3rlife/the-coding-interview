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
            //arrange
            int input = 5;

            //act
            int actual = FactorialNumber.Factorial(input);
            int expected = 120;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
