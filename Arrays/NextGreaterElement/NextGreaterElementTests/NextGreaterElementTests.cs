using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class NextGreaterElementTests
    {
        [TestMethod()]
        public void GetTest()
        {
            //arrange
            int[] input = { 98, 23, 54, 12, 20, 7, 27 };

            //act
            NextGreaterElement.Get(input);

            //asert
        }
    }
}