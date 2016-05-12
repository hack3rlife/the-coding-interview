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
            //arrange
            string input = "4325043";
            string expected = "2043";
           string actual = string.Empty;

            int n = 3;            

            //act
            LowestNumber.BuildLowestNumber(input, n, ref actual);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
