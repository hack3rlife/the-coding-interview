using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace IsAnagramTest
{
    [TestClass]
    public class IsAnagramTest
    {
        [TestMethod]
        public void ASCIIBasedSolutionTestPass()
        {
            //arrange
            string source = "stream";
            string target = "master";

            //act
            bool condition = IsAnagram.ASCIIBasedSolution(source, target);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void ASCIIBasedSolutionTestFail()
        {
            //arrange
            string source = "song";
            string target = "home";

            //act
            bool condition = IsAnagram.ASCIIBasedSolution(source, target);

            //assert
            Assert.IsFalse(condition);
        }
    }
}
