using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.quickselect;

namespace QuickSelectTest
{
    [TestClass]
    public class QuickSelectTest
    {
        [TestMethod]
        public void KthSmallestNumberTest()
        {
            //Arrange
            int[] input = { 12, 3, 5, 7, 4, 19, 26 }; 
            int k = 3;

            //Act
            int actual = QuickSelect.Select(input, 0, input.Length-1, k);
            int expected = 5;

            //Assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
