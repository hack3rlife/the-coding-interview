using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using com.hack3rlife.queue;

namespace QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void EnqueueTest()
        {
            //Arrange
            Queue<int> q = new Queue<int>();
            
            //Act
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Display();

            //Assert
            Assert.AreEqual(3, q.Count);
            Assert.AreEqual(1, q.Peek());
        }

        [TestMethod]
        public void DequeueTest()
        {
            //Arrange
            Queue<int> q = new Queue<int>();

            //Act
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Dequeue();
            q.Display();

            //Assert
            Assert.AreEqual(4, q.Count);
            Assert.AreEqual(2, q.Peek());
        }

        [TestMethod]
        public void ClearTest()
        {
            //Arrange
            Queue<int> q = new Queue<int>();

            //Act
            Random r = new Random(10);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Display();
            q.Clear();
            q.Display();

            //Assert
            Assert.AreEqual(0, q.Count);
            Assert.IsNull(q.head);
            Assert.IsNull(q.tail);
        }
    }
}
