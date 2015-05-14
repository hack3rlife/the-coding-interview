using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace NextGreaterNumberTest
{
    [TestClass]
    public class NextGreaterNumberTest
    {
        [TestMethod]
        public void FindNextTest()
        {
            //Arrange
            string number = "534976";
            
            //Act
            string actual = NextGreaterNumber.FindNext(number);
            string expected = "536479";
            
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
