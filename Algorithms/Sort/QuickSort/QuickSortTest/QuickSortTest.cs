using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSortTest_AverageCaseTest()
        {
            //arrange
            int[] input = new int[] { 8, 1, 3, 9, 4, 5, 0, 2, 7, 6 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            QuickSort.Sort(input, 0, input.Length-1);

            //assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSortTest_BestCaseTest()
        {
            //arrange
            int[] input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            QuickSort.Sort(input, 0, input.Length - 1);

            //assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSortTest_WorstCaseTest()
        {
            //arrange
            int[] input = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            QuickSort.Sort(input, 0, input.Length - 1);

            //assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
