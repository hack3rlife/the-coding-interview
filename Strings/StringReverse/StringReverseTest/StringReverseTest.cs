using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class StringReverseTest
    {
        [TestMethod]
        public void ReverseTest()
        {
            // arrange
            var input = "hack3rlife";
            var expected = "efilr3kcah";
            
            // act
            var actual = StringReverse.Reverse(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseOptimizedTest()
        {
            // arrange
            var input = "I am Hector"; // "hack3rlife";
            var expected = "Hector am I"; //"efilr3kcah";

            // act
            //var actual = StringReverse.Reverse(input.ToCharArray());
            var actual = StringReverse.ReverseWordsInASentece(input);
            // arrange
            Assert.AreEqual(expected, actual);
        }
    }
}
