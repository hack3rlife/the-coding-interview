using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace NumberToStringTest
{
    [TestClass]
    public class NumberToStringTest
    {
        [TestMethod]
        public void NumberToStringMappingTest()
        {
            //Arrange
            string number = "234";

            //Act
            PhoneNumberMnemonic.Map(number);

            //Assert
            //Should print adg adh adi aeg aeh aei afg afh afi bdg bdh bdi beg beh bei bfg bfh bfi cdg cdh cdi ceg ceh cei cfg cfh cfi
        }

        [TestMethod]
        public void GetTest()
        {
            //Arrange
            string number = "234";
            var expected = 
                new System.Collections.Generic.List<string> { "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi" };
            //Act
            var actual = PhoneNumberMnemonic.Get(number);

            //Assert
            //Should print adg adh adi aeg aeh aei afg afh afi bdg bdh bdi beg beh bei bfg bfh bfi cdg cdh cdi ceg ceh cei cfg cfh cfi
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
