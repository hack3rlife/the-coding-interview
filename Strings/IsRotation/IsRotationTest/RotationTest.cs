using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;

namespace IsRotationTest
{
    [TestClass]
    public class RotationTest
    {
        [TestMethod]
        public void IsRotationTestPassed()
        {
            //Arrange
            string source = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi eget lorem sagittis, pretium dolor eget, fermentum dolor. In sed.";
            string target = " consectetur adipiscing elit. Morbi eget lorem sagittis, pretium dolor eget, fermentum dolor. In sed.Lorem ipsum dolor sit amet,";
            

            //Act
            bool condition = Rotation.IsRotation(source,target);

            //Assert
            Assert.IsTrue(condition);
        }
    }
}
