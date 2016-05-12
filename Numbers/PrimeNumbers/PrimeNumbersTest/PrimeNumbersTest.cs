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
            //arrange
            int number = 23;

            //act
            bool condition = PrimeNumbers.isPrimeNumber(number);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void SieveOfEratosthenesTest()
        {
            //arrange
            int number = 30;

            //act
           PrimeNumbers.SieveOfEratosthenes(number);

            //assert
        }
    }
}
