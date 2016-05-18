using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.datastructures
{
    [TestClass()]
    public class StackMaxUnitTest
    {

        [TestMethod]
        public void Stack_UpdateMaxOnPushTest()
        {
            //arrange
            var stack = new StackMax();

            //act
            stack.Push(2);
            stack.Push(2);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(5);
            stack.Push(3);
            stack.Push(3);

            var actual = stack.Max.Value;
            var expected = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_UpdateMaxOnPopTest()
        {
            //arrange
            var stack = new StackMax();

            //act
            stack.Push(2);
            stack.Pop();        
            stack.Push(2);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Push(5);
            stack.Push(3);
            stack.Pop();
            stack.Push(3);

            var actual = stack.Max.Value;
            var expected = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_UpdateMaxOnPushAscendingTest()
        {
            //arrange
            var stack = new StackMax();

            //act
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            var actual = stack.Max.Value;
            var expected = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_UpdateMaxOnPushDescendingTest()
        {
            //arrange
            var stack = new StackMax();

            //act
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(0);

            var actual = stack.Max.Value;
            var expected = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_UpdateMaxOnPopAscendingTest()
        {
            //arrange
            var stack = new StackMax();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //act
            stack.Pop();

            var actual = stack.Max.Value;
            var expected = 4;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_UpdateMaxOnPopDescendingTest()
        {
            //arrange
            var stack = new StackMax();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Push(0);

            //act
            stack.Pop();
            stack.Pop();

            var actual = stack.Max.Value;
            var expected = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}