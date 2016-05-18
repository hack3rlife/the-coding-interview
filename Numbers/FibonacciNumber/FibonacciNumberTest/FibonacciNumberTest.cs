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
            //arrange
            int input = 4;
            //act
            int actual = FibonacciNumber.Fibonacci(input);
            int expected = 34;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciDynamicTest()
        {
            //arrange
            int input = 9;
            //act
            int actual = FibonacciNumber.FibonacciDynamic(input);
            int expected = 34;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FibonacciSequenceTest()
        {
            //arrange
            int input = 9;


            //act
            List<int> actual = FibonacciNumber.FibonacciSequence(input);
            List<int> expected = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            //assert
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
