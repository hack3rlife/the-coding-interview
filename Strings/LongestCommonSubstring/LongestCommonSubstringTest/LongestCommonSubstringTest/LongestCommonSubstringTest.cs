using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace LongestCommonSubstringTest
{
    [TestClass]
    public class LongestCommonSubstringTest
    {
        [TestMethod]
        public void GetLcsTest()
        {
            //Arrange
            string input1 = "OldSite:GeeksforGeeks.org";
            string input2 = "NewSite:GeeksQuiz.com";

            int expected = 10;

            //Act
            int actual = LongestCommonSubstring.GetLCS(input1, input2);

            //Test
            Assert.AreEqual(expected, actual);

        }
    }
}
