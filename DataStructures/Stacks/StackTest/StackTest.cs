using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.hack3rlife.datastructures;
using System.Collections;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushTest()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
         
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
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //Act
            int actual = stack.Pop();
            int expected = 2;

            //Asset
            Assert.AreEqual<int>(expected, actual);            
        }

        [TestMethod]
        public void EmptyStackPopTest()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Pop();

            //Act
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
            //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //Act
            int actual = stack.Peek();
            int expected = 2;

            //Asset
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void CountTest()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            //Act
            int actual = stack.Count;
            int expected = 1;

            //Asset
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void GetEnumeratorTest()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            //Act
            var enumerator = stack.GetEnumerator();

            var actualList = new ArrayList();
            var extpectedList = new int[] {2,1,0};

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);

                actualList.Add(enumerator.Current);
            } 
                       
            //Assert
            CollectionAssert.AreEqual(extpectedList, actualList);
        }
    }
}
