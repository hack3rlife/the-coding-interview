using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace BuildLowestNumberTest
{
    [TestClass]
    public class BuildLowestNumberTest
    {
        [TestMethod]
        public void LowestNumberBuildTest()
        {
            //Arrange
            string input = "4325043";
            string expected = "2043";
           string actual = string.Empty;

            int n = 3;            

            //Act
            LowestNumber.BuildLowestNumber(input, n, ref actual);

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
