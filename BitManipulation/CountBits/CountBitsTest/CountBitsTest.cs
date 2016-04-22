using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.bitmanipulation
{
    [TestClass]
    public class CountBitsTest
    {
        [TestMethod]
        public void CountBits_Test()
        {
            //
            var input = 22;  //0	0	0	1	0	1	1	0
            var expected = 3;

            //act
            var actual = CountBits.Count(input);

            //assert
            Assert.AreEqual(expected, actual);
         }
    }
}
