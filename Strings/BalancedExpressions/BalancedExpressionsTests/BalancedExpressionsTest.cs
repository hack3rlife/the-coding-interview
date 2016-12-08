using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalancedExpressions.Tests
{
    [TestClass()]
    public class BalancedExpressionsTest
    {
        [TestMethod()]
        public void BalancedExpressionsTest_IsBalancedExpressionWithStacks_True_Test()
        {
            // arrange
            string expression = @"(1+2)*[6, 7, 9](){}";

            // act
            var condition = BalancedExpressions.IsBalancedExpressionWithStacks(expression);

            // assert
            Assert.IsTrue(condition);
        }

        [TestMethod()]
        public void BalancedExpressionsTest_IsBalancedExpressionWithStacks_False_Test()
        {
            // arrange
            string expression = @"'{})(";

            // act
            var condition = BalancedExpressions.IsBalancedExpressionWithStacks(expression);

            // assert
            Assert.IsFalse(condition);
        }
    }
}