﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace ConcatenateTwoNumbersTest
{
    [TestClass]
    public class ConcatenateTwoNumbersTest
    {
        [TestMethod]
        public void ConcatenateTest()
        {
            // Arrange
            Random r = new Random();
            int num1 = r.Next(10000);
            int num2 = r.Next(10000);

            // Act
            int actual = ConcatenateTwoNumbers.Concatenate(num1, num2);
            int expected = num1 * 10000 + num2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
