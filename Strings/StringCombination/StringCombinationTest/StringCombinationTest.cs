using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

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
            var expected = new System.Collections.Generic.List<string>() { "a", "ab", "abc", "ac", "b", "bc", "c" };
            // act
            StringCombination.Combine(input, string.Empty, 0);
            var actual = StringCombination.Result;
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
