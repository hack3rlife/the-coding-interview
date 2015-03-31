using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.phonenumberparser;

namespace AlphanumericPhoneNumberTest
{
    [TestClass]
    public class PhoneNumberParserTest
    {
        /// <summary>
        /// dial 1800-CALL-ATT (18002255288) 
        /// </summary>
        [TestMethod]
        public void GetPhoneNumberTest()
        {
            // arrange
            var expected = "18002255288";

            // act
            var actual = PhoneNumberParser.GetPhoneNumber("1-800-CALL-ATT");

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
