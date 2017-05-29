using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.algorithms.searching.test
{
    [TestClass()]
    public class FindMinimumElementTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search_findminimumelement.csv", "binary_search_findminimumelement#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_FindMinimumElement_Recursive_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = (int)TestContext.DataRow[1];

            var arr = Array.ConvertAll(input, s => int.Parse(s));
            
            //act
            var actual = BinarySearch.FindMinimumElement(arr, 0, arr.Length - 1);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\binary_search_findminimumelement.csv", "binary_search_findminimumelement#csv", DataAccessMethod.Sequential)]
        public void BinarySearch_FindMinimumElement_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = (int)TestContext.DataRow[1];

            var arr = Array.ConvertAll(input, s => int.Parse(s));
            //assert
            var actual = BinarySearch.FindMinimumElement(arr);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}