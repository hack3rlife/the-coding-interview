using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.algorithms.sorting;

namespace QuickSelectTest
{
    [TestClass]
    public class QuickSelectTest
    {
        [TestMethod]
        public void QuickSelect_AverageCaseTest()
        {
            //arrange
            int[] input = { 12, 3, 5, 7, 4, 19, 26 }; 
            int k = 1;

            //act
            int actual = QuickSelect.Select(input, 0, input.Length-1, k);
            int expected = 4;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void QuickSelect_BestCaseTest()
        {
            //arrange
            int[] input = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 3;

            //act
            int actual = QuickSelect.Select(input, 0, input.Length - 1, k);
            int expected = 7;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void QuickSelect_WorstCaseTest()
        {
            //arrange
            int[] input = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 6;

            //act
            int actual = QuickSelect.Select(input, 0, input.Length - 1, k);
            int expected = 26;

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
