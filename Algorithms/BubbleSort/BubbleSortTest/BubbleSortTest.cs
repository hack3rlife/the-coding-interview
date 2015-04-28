using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.bubblesort;

namespace BubbleSortTest
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void BSortTest()
        {
            //Arrange
            int[] input = new int[] { 8, 1, 3, 9, 4, 5, 0, 2, 7, 6 };

            //Act
            BubbleSort bubbleSort = new BubbleSort();
            int[] actual = bubbleSort.Sort(input);
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
