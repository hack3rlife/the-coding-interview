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
            //Arrange
            StackQueue<int> stack = new StackQueue<int>();

            //Act
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //Assert
            Assert.IsTrue(stack.Count == 3);
        }

        [TestMethod]
        public void PopTest()
        {
            //Arrange
            StackQueue<int> stack = new StackQueue<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //Act
            int actual = stack.Pop();
            int expected = 2;

            //Asset
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
