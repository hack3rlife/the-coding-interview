using Microsoft.VisualStudio.TestTools.UnitTesting;
using StairCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    [TestClass()]
    public class DrawUnitTest
    {
        [TestMethod()]
        public void StairCase_DrawTest()
        {
            //act
            int n = 6;

            //arrange
            StairCase.DrawRight(n);
        }


        [TestMethod()]
        public void StairCase_DrawLeftTest()
        {
            //act
            int n = 6;

            //arrange
            StairCase.DrawLeft(n);
        }
    }
}