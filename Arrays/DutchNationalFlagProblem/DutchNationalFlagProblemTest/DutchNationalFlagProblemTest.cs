using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;
using System;

namespace com.hack3rlife.array.test
{
    [TestClass]
    public class DutchNationalFlagProblemTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\dnf.csv", "dnf#csv", DataAccessMethod.Sequential)]
        public void DutchNationalFlagProblem_Sort_Test()
        {
            //arrange
            var input = TestContext.DataRow[0].ToString().Split(new char[] { ' ' });
            var expected = TestContext.DataRow[1].ToString().Split(new char[] { ' ' });

            //act
            var actual = DutchNationalFlagProblem.Sort(Array.ConvertAll(input, s => int.Parse(s)), 1);

            //assert

            CollectionAssert.AreEqual(Array.ConvertAll(expected, s => int.Parse(s)), actual);            
        }
    }
}
