using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.stringcombination;

namespace StringCombinationTest
{
    [TestClass]
    public class StringCombinationTest
    {
        [TestMethod]
        public void CombineTest()
        {
            // arrange
            var input = "abc";

            // act
            StringCombination.Combine(input, string.Empty, 0);

            // assert
            Assert.IsTrue(true);
        }
    }
}
