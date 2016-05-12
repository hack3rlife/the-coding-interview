using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void InsertionSort_AverageCaseTest()
        {
            //arrange
            int[] input =    { 3, 7, 4, 9, 5, 2, 6, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 9 };
           
            //act
            int[] actual = InsertionSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertionSort_BestCaseTest()
        {
            //arrange
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 9 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 9 };

            //act
            int[] actual = InsertionSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertionSort_WorstCaseTest()
        {
            //arrange
            int[] input = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //act
            int[] actual = InsertionSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
