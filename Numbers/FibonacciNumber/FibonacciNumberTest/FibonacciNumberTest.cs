using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;
using System.Collections.Generic;

namespace FibonacciNumberTest
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        public void FibonacciTest()
        {
            //Arrange
            int input = 9;
            //Act
            int actual = FibonacciNumber.Fibonacci(input);
            int expected = 34;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FibonacciSequenceTest()
        {
            //Arrange
            int input = 9;


            //Act
            List<int> actual = FibonacciNumber.FibonacciSequence(input);
            List<int> expected = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
