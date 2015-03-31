using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.stringreverse;

namespace StringReverseTest
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
            var input = "hack3rlife";
            var expected = "efilr3kcah";

            // act
            var actual = StringReverse.ReverseOptimized(input);

            // arrange
            Assert.AreEqual(expected, actual);
        }
    }
}
