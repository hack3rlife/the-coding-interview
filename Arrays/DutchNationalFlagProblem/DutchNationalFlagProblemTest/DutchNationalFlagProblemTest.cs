using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.dnf;

namespace DutchNationalFlagProblemTest
{
    [TestClass]
    public class DutchNationalFlagProblemTest
    {
        [TestMethod]
        public void SortTest()
        {
            //Arrange
            int[] input = new int[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };

            //Act
            DutchNationalFlagProblem dnf = new DutchNationalFlagProblem();
            int[] actual = dnf.DNFSort(input, 1);

            //Assert
            int[] expected = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2 };

            CollectionAssert.AreEqual(expected, actual);            
        }
    }
}
