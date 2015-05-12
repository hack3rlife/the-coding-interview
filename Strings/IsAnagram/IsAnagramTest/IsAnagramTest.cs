using System;
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
            //Arrange
            string source = "stream";
            string target = "master";

            //Act
            bool condition = IsAnagram.ASCIIBasedSolution(source, target);

            //Assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void ASCIIBasedSolutionTestFail()
        {
            //Arrange
            string source = "song";
            string target = "home";

            //Act
            bool condition = IsAnagram.ASCIIBasedSolution(source, target);

            //Assert
            Assert.IsFalse(condition);
        }
    }
}
