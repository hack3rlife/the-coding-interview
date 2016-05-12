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
            //arrange
            Queue<int> q = new Queue<int>();
            
            //act
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Display();

            //assert
            Assert.AreEqual(3, q.Count);
            Assert.AreEqual(1, q.Peek());
        }

        [TestMethod]
        public void DequeueTest()
        {
            //arrange
            Queue<int> q = new Queue<int>();

            //act
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Dequeue();
            q.Display();

            //assert
            Assert.AreEqual(4, q.Count);
            Assert.AreEqual(2, q.Peek());
        }

        [TestMethod]
        public void ClearTest()
        {
            //arrange
            Queue<int> q = new Queue<int>();

            //act
            Random r = new Random(10);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Display();
            q.Clear();
            q.Display();

            //assert
            Assert.AreEqual(0, q.Count);
            Assert.IsNull(q.head);
            Assert.IsNull(q.tail);
        }
    }
}
