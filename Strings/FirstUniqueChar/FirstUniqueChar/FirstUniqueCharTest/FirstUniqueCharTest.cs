using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass()]
    public class FirstUniqueCharTest
    {
        [TestMethod()]
        public void FirstUniqueChar_Find_Test()
        {
            //arrange
            string input = "aabbabac";

            //act
            var actual = FirstUniqueChar.Find(input);

            //arrange
            Assert.AreEqual(7, actual);
        }

        [TestMethod()]
        public void FirstUniqueChar_FindInStream_Test()
        {
            //arrange
            string input = "aabbabacdefe";

            //act
            FirstUniqueChar.FindInStream(input.ToCharArray());

            //arrange
        }

        [TestMethod()]
        public void FindInStreamTest()
        {
            Assert.Fail();
        }
    }
}