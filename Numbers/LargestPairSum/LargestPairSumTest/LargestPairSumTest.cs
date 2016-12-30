using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.numbers.test
{
    [TestClass]
    public class LargestPairSumTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void LargestPairSum_Find_Test()
        {
            //arrange
            var input = TestContext.DataRow["input"].ToString().Split(new char[] { ' ' });
            var expected = (int)TestContext.DataRow["sum"];

            //act
            int actual = LargestPairSum.Find(Array.ConvertAll(input, s => int.Parse(s)));

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
