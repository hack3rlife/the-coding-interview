using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace StringPermutationTest
{
    [TestClass]
    public class StringPermutationTest
    {
        [TestMethod]
        public void PermuationTest()
        {
            // arrange
            var input = "ABC";
            var expected = new System.Collections.Generic.List<string> { "ABC", "ACB", "BAC", "BCA", "CBA", "CAB" };

            // act
            StringPermutation.Permute(input);
            var actual = StringPermutation.Result;

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
