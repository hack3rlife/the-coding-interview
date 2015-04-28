using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.mergesort;

namespace MergeSortTest
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void MergeSortTestBase()
        {
            //Arrange
            MergeSort ms = new MergeSort();

            //Act 
            int[] input = new int[] { 8, 1, 3, 9, 4, 5, 0, 2, 7, 6 };

            int[] actual = ms.Sort(input);
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
