using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System.Collections;

namespace com.hack3rlife.datastructures
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushTest()
        {
            //arrange
            Stack stack = new Stack();
         
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
            Stack stack = new Stack();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //act
            int actual = stack.Pop();
            int expected = 2;

            //Asset
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void EmptyStackPopTest()
        {
            //arrange
            Stack stack = new Stack();
            stack.Push(0);
            stack.Pop();

            //act
            try
            {
                int actual = stack.Pop();
            }
            catch (NullReferenceException nre)
            {
                //Asset
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void PeekTest()
        {
            //arrange
            Stack stack = new Stack();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //act
            int actual = stack.Peek();
            int expected = 2;

            //Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountTest()
        {
            //arrange
            Stack stack = new Stack();
            stack.Push(0);
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            //act
            int actual = stack.Count;
            int expected = 1;

            //Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetEnumeratorTest()
        {
            //arrange
            Stack stack = new Stack();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //act
            var enumerator = stack.GetEnumerator();

            var actualList = new ArrayList();
            var extpectedList = new int[] {2,1,0};

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);

                actualList.Add(enumerator.Current);
            } 
                       
            //assert
            CollectionAssert.AreEqual(extpectedList, actualList);
        }
    }
}
