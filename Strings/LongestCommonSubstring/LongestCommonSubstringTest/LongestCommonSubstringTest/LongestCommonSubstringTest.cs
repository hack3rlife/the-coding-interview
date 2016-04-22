using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace LongestCommonSubstringTest
{
    [TestClass]
    public class LongestCommonSubstringTest
    {
        [TestMethod]
        public void GetLengthTest()
        {
            //Arrange
            string input1 = "OldSite:GeeksforGeeks.org";
            string input2 = "NewSite:GeeksQuiz.com";

            int expected = 10;

            //Act
            int actual = LongestCommonSubstring.GetLength(input1, input2);

            //Test
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSubstringTest()
        {
            //Arrange
            string input1 = "GeeksforGeeks";
            string input2 = "GeeksQuiz";

            System.Collections.Generic.List<string> expected = new System.Collections.Generic.List<string> { "Geeks", "Geeks" };

            //Act
            var actual = LongestCommonSubstring.GetSubstring(input1, input2);

            //Test
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
