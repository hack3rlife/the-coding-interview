using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.strings.test
{
    [TestClass()]
    public class StringCompressionTests
    {
        [TestMethod()]
        public void StringCompression_Zip_Test()
        {
            // arrange
            var input = "aabccccaa";

            // act
            var actual = StringCompression.Zip(input);

            // assert
            Assert.AreEqual<string>(actual, "a2b1c4a2");
        }
    }
}