using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.queue;

namespace QueueTest
{
    [TestClass]
    public class QueueStackTest
    {
        [TestMethod]
        public void EnqueueTest()
        {
            //Arrange
            QueueStack<int> q = new QueueStack<int>();

            //Act
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            //Assert
            Assert.AreEqual(3, q.Count);
        }

        [TestMethod]
        public void DequeueTest()
        {
            //Arrange
            QueueStack<int> q = new QueueStack<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            //Act
            
           int actual = q.Dequeue();
           int expected = 1;

            //Assert
           Assert.AreEqual<int>(expected,actual);
            Assert.AreEqual(4, q.Count);
        }
    }
}
