using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.quicksort;

namespace QuickSortTest
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QSTest()
        {
            //Arrange
            int[] input = new int[] { 8, 1, 3, 9, 4, 5, 0, 2, 7, 6 };
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Act
            QuickSort.Sort(input, 0, input.Length-1);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
