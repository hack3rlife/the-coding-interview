using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class StringReverseTest
    {
        [TestMethod]
        public void StringReverse_Reverse_Test()
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
        public void StringReverse_ReverseOptimized_Test()
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

        [TestMethod]
        public void StringReverse_RecursiveMethod_Test()
        {
            // arrange
            var input = "hack3rlife";
            var expected = "efilr3kcah";

            // act
            var actual = StringReverse.Reverse(input.ToCharArray(), 0, input.Length-1);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StringReverse_RecursiveMethod()
        {
            // arrange
            var input = "Candidates pass interview";
            var expected = "setadidnaC ssap weivretni";

            // act
            var actual = StringReverse.ReverseWordsInASentece(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
