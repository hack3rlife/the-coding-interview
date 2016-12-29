using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass()]
    public class BalancedExpressionsTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\valid_balancedexpressions.csv", "valid_balancedexpressions#csv", DataAccessMethod.Sequential)]
        public void BalancedExpressions_IsBalancedExpression_True_Test()
        {
            // arrange
            string expression = TestContext.DataRow[0].ToString();

            // act
            var condition = BalancedExpressions.IsBalancedExpressionWithStacks(expression);

            // assert
            Assert.IsTrue(condition);
        }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\invalid_balancedexpressions.csv", "invalid_balancedexpressions#csv", DataAccessMethod.Sequential)]
        public void BalancedExpressions_IsBalancedExpression_False_Test()
        {
            // arrange
            string expression = TestContext.DataRow["expression"].ToString();

            // act
            var condition = BalancedExpressions.IsBalancedExpressionWithStacks(expression);

            // assert
            Assert.IsFalse(condition);
        }

        [TestMethod()]
        public void BalancedExpressions_IsBalancedExpression_EmptyExpression_Test()
        {
            // arrange
            string expression = @"";

            // act
            var condition = BalancedExpressions.IsBalancedExpressionWithStacks(expression);

            // assert
            Assert.IsFalse(condition);
        }

        [TestMethod()]
        public void BalancedExpressions_IsBalancedExpression_NullExpression_Test()
        {
            // arrange

            // act
            var condition = BalancedExpressions.IsBalancedExpressionWithStacks(null);

            // assert
            Assert.IsFalse(condition);
        }
    }
}