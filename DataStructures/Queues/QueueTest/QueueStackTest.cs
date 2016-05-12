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
            //arrange
            QueueStack<int> q = new QueueStack<int>();

            //act
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            //assert
            Assert.AreEqual(3, q.Count);
        }

        [TestMethod]
        public void DequeueTest()
        {
            //arrange
            QueueStack<int> q = new QueueStack<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            //act
            
           int actual = q.Dequeue();
           int expected = 1;

            //assert
           Assert.AreEqual<int>(expected,actual);
            Assert.AreEqual(4, q.Count);
        }
    }
}
