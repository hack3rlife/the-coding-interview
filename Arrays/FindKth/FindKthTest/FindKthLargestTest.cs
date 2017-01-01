using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass]
    public class FindKthLargestTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void FindKth_LargestTest()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var k = (int)TestContext.DataRow[1];
            var expected = (int)TestContext.DataRow[2];

            //act
            var actual = FindKthLargest.Find(Array.ConvertAll(input, s => int.Parse(s)), k);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
