using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.Tests
{
    [TestClass()]
    public class IsomorphicTest
    {
        [TestMethod()]
        public void IsIsomorphic_IsIsomorphic_NoError_Test()
        {
            // arrange
            var input1 = "aab";
            var input2 = "xxy";

            // act
            var condition = Isomorphic.IsIsomorphic(input1, input2);

            // assert
            Assert.IsTrue(condition);

        }

        [TestMethod()]
        public void IsIsomorphic_IsIsomorphic_Error_Test()
        {
            // arrange
            var input1 = "abc";
            var input2 = "xxy";

            // act
            var condition = Isomorphic.IsIsomorphic(input1, input2);

            // assert
            Assert.IsFalse(condition);

        }
    }
}