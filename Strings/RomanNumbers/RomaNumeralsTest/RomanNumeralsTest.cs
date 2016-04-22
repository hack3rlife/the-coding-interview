using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings
{
    [TestClass]
    public class RomanNumeralsTest
    {
        [TestMethod]
        public void Test()
        {
            //arrange
            var number = 1663;
            var expected = "MDCLXIII";

            //act
           var actual = RomanNumerals.NumberToRoman(number);

            //assert
            Assert.AreEqual<string>(expected, actual);
        }
    }
}
