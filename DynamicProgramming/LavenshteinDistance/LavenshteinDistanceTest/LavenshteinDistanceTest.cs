using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class LavenshteinDistanceTest
    {
        [TestMethod]
        public void LavenshteinDistance_Get_Test()
        {
            //arrange
            var s1 = "Sunday";
            var s2 = "Saturday";

            //act
            var total = LavenshteinDistance.Get(s1, s2);

            //test
            Assert.AreEqual(3, total);
        }
    }
}
