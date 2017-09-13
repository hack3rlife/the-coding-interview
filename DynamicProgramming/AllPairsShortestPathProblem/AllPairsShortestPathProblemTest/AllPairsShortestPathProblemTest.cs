using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.dynamicprogramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.dynamicprogramming.Test
{
    [TestClass()]
    public class AllPairsShortestPathProblemTest
    {
        /* Let us create the following weighted graph
                10
           (0)------->(3)
           |         /|\
         5 |          |
           |          | 1
          \|/         |
           (1)------->(2)
                  3           
         */
        [TestMethod()]
        public void FloydWarshallTest()
        {
            //arrange
            int[,] input = new int[,]
            {
                {0,   5,  int.MaxValue, 10},
                {int.MaxValue, 0,   3, int.MaxValue},
                {int.MaxValue, int.MaxValue, 0,   1},
                {int.MaxValue, int.MaxValue, int.MaxValue, 0}
            };

            //act
            AllPairsShortestPathProblem.FloydWarshall(input);

            //arrange
        }
    }
}