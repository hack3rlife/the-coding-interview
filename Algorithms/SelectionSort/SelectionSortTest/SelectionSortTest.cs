using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.selectionsort
{
    [TestClass]
    public class SelectionSortTest
    {
        [TestMethod]
        public void SelectionSort_SortTest()
        {
            //Arrange 
            int[] input =    { 64, 25, 12, 22, 11 };
            int[] expected = { 11, 12, 22, 25, 64 };

            //Act
            SelectionSort selection = new SelectionSort();
            int[] actual = selection.Sort(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
