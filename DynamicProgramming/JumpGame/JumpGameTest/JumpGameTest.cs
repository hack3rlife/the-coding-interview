using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass()]
    public class JumpGameTest
    {
        [TestMethod()]
        public void MinJumps_RecursiveMethod_Test()
        {
            //arrange
            int[] input = new int[] { 2, 3, 1, 1, 4 };

            //act 
            int actual = JumpGame.MinJumps(input, 0, input.Length - 1);

            //assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void MinJumps_RecursieMethod_Test()
        {
            //arrange
            //int[] input = new int[] { 2, 3, 1, 1, 4 };
            //int[] input = new int[] { 1, 3, 6, 1, 0, 9 };
            int[] input = new int[] { 1, 3, 6, 3, 2, 3, 6, 8, 9, 5 };

            //act 
            int actual = JumpGame.MinJumps(input);

            //assert
            Assert.AreEqual(4, actual);
        }
    }
}