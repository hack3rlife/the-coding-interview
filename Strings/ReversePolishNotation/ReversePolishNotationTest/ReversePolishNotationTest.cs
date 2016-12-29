using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass()]
    public class ReversePolishNotationTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\rpn_expressions.csv", "rpn_expressions#csv", DataAccessMethod.Sequential)]
        public void ReversePolishNotation_NoError_Succeed()
        {
            // arrange
            var tokens = TestContext.DataRow["input"].ToString().Split(new char[] { ' ' });
            var expected = (int)TestContext.DataRow["output"];

            // act
            var actual = ReversePolishNotation.EvalRPN(tokens);

            // test
            Assert.AreEqual(expected, actual);

        }
    }
}