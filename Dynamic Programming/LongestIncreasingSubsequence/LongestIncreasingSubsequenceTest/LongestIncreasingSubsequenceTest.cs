using System;
using com.hack3rlife.thecodinginterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.thecodinginterview.test
{
    [TestClass]
    public class LongestIncreasingSubsequenceTest
    {
        [TestMethod]
        public void GetLongestIncreasingSubsequence()
        {
            // arrange
            int[] input = { 3, 4, -1, 0, 6, 2, 3 };

            // act           
            var actual = LongestIncreasingSubsequence.Get(input);

            // assert
            var expected = 4;
            Assert.AreEqual<int>(expected, actual);
            
        }
    }
}
