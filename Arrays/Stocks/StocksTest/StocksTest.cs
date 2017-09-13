using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Test
{
    [TestClass()]
    public class StocksTest
    {
        [TestMethod()]
        public void BestTimeTest()
        {
            //arrange
            var input = new int[] { 7, 1, 5, 3, 6, 4 };

            //act
            var actual = Stocks.BestTimeI(input);

            //assert
            Assert.AreEqual<int>(5, actual);
        }

        [TestMethod()]
        public void BestTimeIITest()
        {
            //arrange
            var input = new int[] { 100, 180, 260, 310, 40, 535, 695 };

            //act
            var actual = Stocks.BestTimeII(input);

            //assert
            Assert.AreEqual<int>(865, actual);
        }

        [TestMethod()]
        public void BestTimeIITest2()
        {
            //arrange
            var input = new int[] { 100, 80, 120, 130, 70, 60, 100, 125 };

            //act
            var actual = Stocks.BestTimeII(input);

            //assert
            Assert.AreEqual<int>(115, actual);
        }

        [TestMethod()]
        public void BestTimeIIITest()
        {
            //arrange
            var input = new int[] { 12, 11, 13, 9, 12, 8, 14, 13, 15 };

            //act
            var actual = Stocks.BestTimeIII(input);

            //assert
            Assert.AreEqual<int>(10, actual);
        }
    }
}