using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.Test
{
    [TestClass()]
    public class MakingAnagramsTest
    {
        [TestMethod()]
        public void GetTest()
        {
            int result = MakingAnagrams.Get("tttttttttttttttttttttttttttttttttttttsssssssssssssssss", "sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss");
        }
    }
}