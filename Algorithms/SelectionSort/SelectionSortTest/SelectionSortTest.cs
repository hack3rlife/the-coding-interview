using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.sorting
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void SelectionSort_AverageCaseTest()
        {
            //arrange 
            int[] input =    { 64, 25, 12, 22, 11 };
            int[] expected = { 11, 12, 22, 25, 64 };

            //act
            int[] actual = SelectionSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectionSort_BestCaseTest()
        {
            //arrange 
            int[] input = { 11, 12, 22, 25, 64 };
            int[] expected = { 11, 12, 22, 25, 64 };

            //act
            int[] actual = SelectionSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectionSort_WorstCaseTest()
        {
            //arrange 
            int[] input = { 64, 25, 22, 12, 11 };
            int[] expected = { 11, 12, 22, 25, 64 };

            //act
            int[] actual = SelectionSort.Sort(input);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
