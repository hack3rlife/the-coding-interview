using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeftRotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation.Test
{
    [TestClass()]
    public class ArrayRotationTest
    {
        [TestMethod()]
        public void ReverseRotationTest()
        {
            var input1 = new int[] { 1, 2, 3, 4, 5 };
            var input2 = new int[] { 1, 2, 3, 4, 5 };

            var reverse = ArrayRotation.ReverseRotation(input1, 4);

            var left = ArrayRotation.LeftRotation(input2, 4);

            CollectionAssert.AreEqual(reverse, left);
        }
    }
}