using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class TwoSumProblemTest
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            // arrange
            var input = new int[] { 3, 2, 4 };

            // act
            var actual = TwoSumProblem.TwoSum(input, 6);

            // assert
            var expected = new int[] { 1, 2 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}