using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class DeleteNAfterMTest:LinkedListBaseTest
    {
        [TestMethod]
        public void DeleteNAfterM()
        {
            list.DeleteNAfterM(2, 2);
            list.Display();
        }
    }
}
