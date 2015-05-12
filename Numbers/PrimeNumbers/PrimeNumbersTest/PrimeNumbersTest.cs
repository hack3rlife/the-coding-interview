using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.numbers;

namespace PrimeNumbersTest
{
    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void isPrimeNumberTest()
        {
            //Arrange
            int number = 23;

            //Act
            bool condition = PrimeNumbers.isPrimeNumber(number);

            //Assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void SieveOfEratosthenesTest()
        {
            //Arrange
            int number = 30;

            //Act
           PrimeNumbers.SieveOfEratosthenes(number);

            //Assert
        }
    }
}
