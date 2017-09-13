using com.hack3rlife.algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumSubarrayProblemTest
{
    [TestClass]
    public class MaximumSubarrayProblemTest
    {
        [TestMethod]
        public void MaximumSubarrayProblem_GetLargestSumTest()
        {
            //arrange
            int[] input = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            int expected = 7;

            //act
            int actual = MaximumSubarrayProblem.MaxSubArraySum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MaximumSubarrayProblem_GetLargestSumTest_OnlyNegatives()
        {
            //arrange
            int[] input = new int[] { -2, -3, -4, -1, -2, -1, -5, -3 };
            int expected = -1;

            //act
            int actual = MaximumSubarrayProblem.MaxSubArraySum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumSubarrayProblem_GetLargestSumTest_OnlyPositives()
        {
            //arrange
            int[] input = new int[] { 2, 3, 4, 1, 2, 1, 5, 3 };
            int expected = 21;

            //act
            int actual = MaximumSubarrayProblem.MaxSubArraySum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumSubarrayProblem_GetLargestSumTest_SubArrayAtTheBeginning()
        {
            //arrange
            int[] input = new int[] { 2, 3, -4, -1, -2, -1, -5, -3 };
            int expected = 5;

            //act
            int actual = MaximumSubarrayProblem.MaxSubArraySum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumSubarrayProblem_GetLargestSumTest_SubArrayAtTheEnd()
        {
            //arrange
            int[] input = new int[] { -2, -3, -4, -1, -2, -1, 5, 3 };
            int expected = 8;

            //act
            int actual = MaximumSubarrayProblem.MaxSubArraySum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumSubarrayProblem_GetLargestSumTest_OnePositiveOneNegative()
        {
            //arrangem
            int[] input = new int[] { -1, 2, -3, 4, -5, 6 };
            int expected = 6;

            //act
            int actual = MaximumSubarrayProblem.MaxSubArraySum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
