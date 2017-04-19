using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace com.hack3rlife.dynamicprogramming
{
    [TestClass]
    public class SubSetSumTest
    {
        [TestMethod]
        public void SubSetSum_IsSubsetSum_Test1()
        {
            //arrange
            int[] input = new int[] { 3, 34, 4, 12, 5, 2 };

            //act
            bool condition = SubSetSum.IsSubSetSum(input, input.Length, 7);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void SubSetSum_IsSubsetSum_Test2()
        {
            //arrange
            int[] input = new int[] { 1, 3, 9, 2 };

            //act
             bool condition = SubSetSum.IsSubSetSum(input, 5);

            //assert
            Assert.IsTrue(condition);
        }
    }
}
