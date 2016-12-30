using com.hack3rlife.numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace om.hack3rlife.numbers.test
{
    [TestClass]
    public class FactorialNumberTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\factorial_numbers.csv", "factorial_numbers#csv", DataAccessMethod.Sequential)]
        public void FactorialNumber_Factorial_Succeed()
        {
            // arrange
            var input = int.Parse(TestContext.DataRow["input"].ToString());
            var expected = long.Parse(TestContext.DataRow["output"].ToString());

            // act
            var actual = FactorialNumber.Factorial(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
