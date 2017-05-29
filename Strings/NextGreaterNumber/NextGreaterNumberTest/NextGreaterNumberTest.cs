using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class NextGreaterNumberTest
    {
        [TestMethod]
        public void NextGreaterNumber_FindNext_Test()
        {
            //arrange
            string number = "534976";

            //act
            string actual = NextGreaterNumber.Next(number);
            string expected = "536479";

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
