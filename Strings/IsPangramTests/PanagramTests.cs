using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.Tests
{
    [TestClass()]
    public class PanagramTests
    {


        [TestMethod()]
        public void IsPanagramTestPositive()
        {
            var result = Panagram.IsPanagram("We promptly judged antique ivory buckles for the next prize");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPanagramTestNegative()
        {
            var result = Panagram.IsPanagram("We promptly judged antique ivory buckles for the prize");
            Assert.IsFalse(result);
        }
    }
}