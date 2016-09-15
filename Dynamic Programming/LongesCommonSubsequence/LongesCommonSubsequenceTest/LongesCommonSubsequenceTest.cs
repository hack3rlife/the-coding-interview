/*
 * @autor: Some smart guy on internet
 * @date: 21/04/2015
 * @project: LongesCommonSubsequence
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetLengthTest()
        {
            //arrange
            var x = "AGGTAB";
            var y = "GXTXAYB";

            var expected = 4; //GTAB
            //act
            var actual = LongesCommonSubsequence.GetLength(x, y);

            //assert
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
