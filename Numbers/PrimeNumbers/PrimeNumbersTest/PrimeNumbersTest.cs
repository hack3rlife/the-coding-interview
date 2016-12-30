using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.numbers.test
{
    [TestClass]
    public class PrimeNumbersTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\prime_numbers.csv", "prime_numbers#csv", DataAccessMethod.Sequential)]
        public void PrimeNumbers_IsPrimeNumber_Test()
        {
            //arrange
            var input = (int)TestContext.DataRow["number"];
            var expected = TestContext.DataRow["isprime"].Equals(0) ? false : true;

            //act
            bool condition = PrimeNumbers.IsPrimeNumber(input);

            //assert
            Assert.IsTrue(condition == expected);
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
