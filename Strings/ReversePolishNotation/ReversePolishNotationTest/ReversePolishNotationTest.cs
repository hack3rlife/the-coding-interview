using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReversePolishNotation.Test
{
    [TestClass()]
    public class ReversePolishNotationTest
    {
        [TestMethod()]
        public void ReversePolishNotation_NoError_Test1()
        {
            // arrange
            var tokens = new string[] { "4", "13", "5", "/", "+" };

            // act
            var actual = ReversePolishNotation.EvalRPN(tokens);

            // test
            var expected = 6;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ReversePolishNotation_NoError_Test2()
        {
            // arrange
            var tokens = new string[] { "2", "1", "+", "3", "*" };

            // act
            var actual = ReversePolishNotation.EvalRPN(tokens);

            // test
            var expected = 9;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ReversePolishNotation_NoError_Test3()
        {
            // arrange
            var tokens = new string[] { "5", "1", "2", "+", "4", "*", "+", "3", "-" };

            // act
            var actual = ReversePolishNotation.EvalRPN(tokens);

            // test
            var expected = 14;
            Assert.AreEqual(expected, actual);

        }
    }
}