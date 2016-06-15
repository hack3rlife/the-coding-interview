using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.random
{
    [TestClass]
    public class RatioIteratorTest
    {
        [TestMethod]
        public void GetRatioTest()
        {
            //arrange
            var numbers = new[] { 200, 500, 200, 401, 200, 200, 401, 401, 200, 200, 500, 503, 400, 200, 404, 404, 200 };
            var iterator = new RatioIterator(numbers);
            var actual = new List<double>();
            //act
            while (iterator.hasNext())
            {
                var curr = iterator.getNext();

                var ratio = iterator.getRatio(curr);

                actual.Add(ratio);
            }
        }
    }
}
