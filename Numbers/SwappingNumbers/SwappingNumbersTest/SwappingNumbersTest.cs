using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.numbers.test
{
    [TestClass]
    public class SwappingNumbersTest
    {
        [TestMethod]
        public void SwappingNumbers_Swap_Test()
        {
            // arrange
            int a = 10;
            int b = 5;

            int d = 10;
            int e = 5;

            // act
            SwappingNumbers.BitwiseSwap(ref a, ref b);
            SwappingNumbers.BitwiseSwap(ref d, ref e);

            // assert
            Assert.AreEqual(a, d);
            Assert.AreEqual(b, e);
            
        }      

        [TestMethod]
        public void SwappingNumbers_ArithmeticSwap_Test()
        {
            // arrange
            int num1 = 10;
            int num2 = 5;

            // act
            SwappingNumbers.ArithmeticSwap(ref num1, ref num2);

            // assert
            Assert.AreEqual(5, num1);
            Assert.AreEqual(10, num2);
        }
    }
}
