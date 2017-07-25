using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass()]
    public class IsPalindromeOfPermutationTests
    {
        [TestMethod()]
        public void IsPalindromeOfPermutationTest()
        {
            // arrange
            var input = "tact coa";

            // act
            var result = Palindrome.IsPalindromeOfPermutation(input);

            // assert
            Assert.IsTrue(result);
        }
    }
}