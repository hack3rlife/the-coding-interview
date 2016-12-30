using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.numbers.test
{
    [TestClass]
    public class FibonacciNumberTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\fibonacci_numbers.csv", "fibonacci_numbers#csv", DataAccessMethod.Sequential)]
        public void FibonacciNumber_Fibonacci_Recursive_Test()
        {
            //arrange
            var input = (int)TestContext.DataRow[0];
            var expected = long.Parse(TestContext.DataRow[1].ToString());

            //act
            var actual = FibonacciNumber.Fibonacci(input);

            //assert
            Assert.AreEqual(expected, actual, string.Format("There is no output value for input: {0}. The current output value is: {1}", TestContext.DataRow[0], TestContext.DataRow[1]));
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\fibonacci_numbers.csv", "fibonacci_numbers#csv", DataAccessMethod.Sequential)]
        public void FibonacciNumber_Fibonacci_DynamicProgramming_Test()
        {
            //arrange
            var input = (int)TestContext.DataRow[0];
            var expected = long.Parse(TestContext.DataRow[1].ToString());

            //act
            var actual = FibonacciNumber.FibonacciDynamic(input);

            //assert
            Assert.AreEqual(expected, actual, string.Format("There is no output value for input: {0}. The current output value is: {1}", TestContext.DataRow[0], TestContext.DataRow[1]));

        }

        [TestMethod]
        public void FibonacciSequenceTest()
        {
            //arrange
            int input = 9;


            //act
            List<long> actual = FibonacciNumber.FibonacciSequence(input);
            List<long> expected = new List<long>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            //assert
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
