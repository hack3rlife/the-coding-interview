using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.stringpermutation;

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

            // act
            StringPermutation.Permute(input);

            // assert
        }
    }
}
