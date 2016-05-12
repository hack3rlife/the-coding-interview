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
            //arrange
            string number = "234";

            //act
            PhoneNumberMnemonic.Map(number);

            //assert
            //Should print adg adh adi aeg aeh aei afg afh afi bdg bdh bdi beg beh bei bfg bfh bfi cdg cdh cdi ceg ceh cei cfg cfh cfi
        }

        [TestMethod]
        public void GetTest()
        {
            //arrange
            string number = "234";
            var expected = 
                new System.Collections.Generic.List<string> { "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi" };
            //act
            var actual = PhoneNumberMnemonic.Get(number);

            //assert
            //Should print adg adh adi aeg aeh aei afg afh afi bdg bdh bdi beg beh bei bfg bfh bfi cdg cdh cdi ceg ceh cei cfg cfh cfi
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
