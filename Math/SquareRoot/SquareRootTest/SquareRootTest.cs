using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.math
{
    [TestClass]
    public class SquareRootTest
    {
        [TestMethod]
        public void SquareRoot_OddNumberTest()
        {
            //arrange
            var number = 9;
            var expected = 3;

            //act
            var actual = SquareRoot.Get(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareRoot_EvenNumberTest()
        {
            //arrange
            var number = 10;
            var expected = 3.1622776601683791;

            //act
            var actual = SquareRoot.Get(number);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
