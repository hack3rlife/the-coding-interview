using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass ()]
    public class ArrayRotationTest
    {
        [TestMethod ()]
        public void ReverseRotationTest()
        {
            var input1 = new int[] { 1, 2, 3, 4, 5 };
            var input2 = new int[] { 1, 2, 3, 4, 5 };

            var reverse = ArrayRotation.ReverseRotation (input1, 4);

            var left = ArrayRotation.LeftRotation (input2, 4);

            CollectionAssert.AreEqual (reverse, left);
        }
    }
}