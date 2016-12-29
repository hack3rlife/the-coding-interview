using com.hack3rlife.strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class RotationTest
    {
        [TestMethod]
        public void Rotation_IsRotation_Succeed()
        {
            //arrange
            string source = "abcdef";
            string target = "defabc";

            //act
            bool condition = Rotation.IsRotation(source, target);

            //assert
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void Rotation_IsRotation_Fail()
        {
            //arrange
            string source = "abcdef";
            string target = "defabb";

            //act
            bool condition = Rotation.IsRotation(source, target);

            //assert
            Assert.IsFalse(condition);
        }

        [TestMethod]
        public void Rotation_IsRotation_DiffLength_Fail()
        {
            //arrange
            string source = "abcdef";
            string target = "defab";

            //act
            bool condition = Rotation.IsRotation(source, target);

            //assert
            Assert.IsFalse(condition);

        }

        [TestMethod]
        public void Rotation_IsRotation_NullString_Fail()
        {
            //arrange
            string source = "abcdef";
            string target = "defab";

            //act
            bool condition = Rotation.IsRotation(null, target);

            //assert
            Assert.IsFalse(condition);

        }

        [TestMethod]
        public void Rotation_IsRotation_EmptyString_Fail()
        {
            //arrange
            string source = "abcdef";
            string target = "";

            //act
            bool condition = Rotation.IsRotation(source, target);

            //assert
            Assert.IsFalse(condition);

        }

    }
}
