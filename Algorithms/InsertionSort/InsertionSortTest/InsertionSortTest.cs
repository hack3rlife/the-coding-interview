using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.insertionsort
{
    [TestClass]
    public class InsertionSortTest
    {
        [TestMethod]
        public void InsertionSort_SortTest()
        {
            //Arrange
            int[] input = { 3, 7, 4, 9, 5, 2, 6, 1 };
            int[] expected = { 1, 2, 3, 4, 6, 7, 9 };
           
            //Act
            InsertionSort insertion = new InsertionSort();
            int[] actual = insertion.Sort(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
