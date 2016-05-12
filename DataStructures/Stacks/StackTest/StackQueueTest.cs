using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;

namespace StackTest
{
    [TestClass]
    public class StackQueueTest
    {
        [TestMethod]
        public void PushTest()
        {
            //arrange
            StackQueue<int> stack = new StackQueue<int>();

            //act
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //assert
            Assert.IsTrue(stack.Count == 3);
        }

        [TestMethod]
        public void PopTest()
        {
            //arrange
            StackQueue<int> stack = new StackQueue<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //act
            int actual = stack.Pop();
            int expected = 2;

            //Asset
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
