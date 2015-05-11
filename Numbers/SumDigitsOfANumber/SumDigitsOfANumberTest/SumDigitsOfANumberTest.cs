using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace SumDigitsOfANumberTest
{
    [TestClass]
    public class SumDigitsOfANumberTest
    {
        [TestMethod]
        public void SumDigitsTest()
        {
            //Arrange
            int input = 12345;            

            //Act
            int actual = SumDigitsOfANumber.SumDigits(input);
             int expected = 6;

            //Assert
             Assert.AreEqual(expected, actual);
        }
    }
}
