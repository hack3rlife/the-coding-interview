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
            //arrange
            int input = 12345;            

            //act
            int actual = SumDigitsOfANumber.SumDigits(input);
             int expected = 6;

            //assert
             Assert.AreEqual(expected, actual);
        }
    }
}
