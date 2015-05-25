using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.hack3rlife.datastructures;

namespace LinkedListTest
{
    [TestClass]
    public class ReverseAlternateNodesAndAppendAtTheEndTest : LinkedListBaseTest
    {
        [TestMethod]
        public void ReverseAndAppend()
        {
            
            list.ReverseAlternateNodesAndAppendAtTheEnd();
            list.Display();
        }
    }
}
