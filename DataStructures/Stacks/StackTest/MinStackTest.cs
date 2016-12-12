using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures.Test
{
    [TestClass()]
    public class StackMinTest
    {
        [TestMethod()]
        public void StackMin_Push_Ascending_Test()
        {
            //arrange
            var stack = new StackMin();

            //act
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            var actual = stack.GetMin();

            //assert
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StackMin_Push_Descending_Test()
        {
            //arrange
            var stack = new StackMin();

            //act
            stack.Push(7);
            stack.Push(6);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(0);

            var actual = stack.GetMin();

            //assert
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StackMin_Push_Test()
        {
            //arrange
            var stack = new StackMin();

            //act
            stack.Push(9);
            stack.Push(9);
            stack.Push(6);
            stack.Push(5);
            stack.Push(7);
            stack.Push(8);
            stack.Push(3);
            stack.Push(4);

            var actual = stack.GetMin();

            //assert
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StackMin_Pop_Ascending_Test()
        {
            //arrange
            var stack = new StackMin();

            //act
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Pop();

            var actual = stack.GetMin();

            //assert
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StackMin_Pop_Descending_Test()
        {
            //arrange
            var stack = new StackMin();

            //act
            stack.Push(7);
            stack.Push(6);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(0);
            stack.Pop();

            var actual = stack.GetMin();

            //assert
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StackMin_Pop_Test()
        {
            //arrange
            var stack = new StackMin();

            //act
            stack.Push(9);
            stack.Push(9);
            stack.Push(6);
            stack.Push(5);
            stack.Push(7);
            stack.Push(8);
            stack.Push(3);
            stack.Pop();

            var actual = stack.GetMin();

            //assert
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}