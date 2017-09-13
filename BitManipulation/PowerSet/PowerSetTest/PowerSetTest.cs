using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.bitmanipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.bitmanipulation.test
{
    [TestClass()]
    public class PowerSetTest
    {
        [TestMethod()]
        public void GetTest()
        {
            //arrange
            var set = new string[] { "a", "b", "c" };

            //act
            PowerSet.Get(set);
        }
    }
}