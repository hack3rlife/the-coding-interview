using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class NextGreaterElementTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential)]
        public void NextGreaterElement_Get_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = TestContext.DataRow[1].ToString();

            //act
            var actual = NextGreaterElement.Get(Array.ConvertAll(input, s => int.Parse(s)));

            //asert
            Assert.AreEqual(expected, actual);
        }
    }
}