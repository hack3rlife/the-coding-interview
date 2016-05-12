using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void BubbleSort_AverageCaseTest()
        {
            //arrange
            int[] input = new int[] { 8, 1, 3, 9, 4, 5, 0, 2, 7, 6 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            int[] actual = BubbleSort.Sort(input);
            
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BubbleSort_BestCaseTest()
        {
            //arrange
            int[] input = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            int[] actual = BubbleSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BubbleSort_WorstCaseTest()
        {
            //arrange
            int[] input = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            int[] actual = BubbleSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
