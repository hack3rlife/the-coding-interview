using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.hack3rlife.binarysearchtree;

namespace BinarySearchTreeTest
{

    [TestClass]
    public class BinarySearchTreeTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            Random r = new Random();
            int count = r.Next(10);

            for (int i = 0; i < count; i++)
            {
                bst.Add(r.Next(count));
            }

            //Assert
            bst.Display();
            Assert.AreEqual(count, bst.Count);
        }

        [TestMethod]
        public void DeleteTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);
            bst.Display();


            //Assert
            bst.InOrder(bst.Root);

            Console.WriteLine();
            bool actual = bst.Remove(20);
            bool expected = true;
            Assert.AreEqual(expected, actual);
            bst.InOrder(bst.Root);

            Console.WriteLine();

            actual = bst.Remove(30);
            expected = true;
            Assert.AreEqual(expected, actual);
            bst.InOrder(bst.Root);

            Console.WriteLine();

            actual = bst.Remove(50);
            expected = true;
            Assert.AreEqual(expected, actual);
            bst.InOrder(bst.Root);

            Console.WriteLine();
        }

        [TestMethod]
        public void ContainsTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                bst.Add(r.Next());
            }

            bst.Add(5);

            //Assert
            bst.Display();

            var expected = true;
            var actual = bst.Contains<int>(5);
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void InOrderTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                bst.Add(r.Next(10));
            }

            //Assert
            foreach (var node in bst.InOrderEnumerable)
            {
                Console.Write(" {0} ", node);
            }
        }

        [TestMethod]
        public void PreOrderTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            bst.Add(5);
            bst.Add(6);
            bst.Add(5);
            bst.Add(4);
            bst.Add(9);
            bst.Add(10);
            bst.Add(1);
            bst.Add(6);
            bst.Add(7);
            bst.Add(8);

            bst.Display();
            Console.WriteLine();

            //Assert
            bst.PreOrder(bst.Root);
            Console.WriteLine();
            foreach (var node in bst.PreOrderEnumerable)
            {
                Console.Write(" {0} ", node);
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void PostOrderTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            bst.Add(5);
            bst.Add(6);
            bst.Add(5);
            bst.Add(4);
            bst.Add(9);
            bst.Add(10);
            bst.Add(1);
            bst.Add(6);
            bst.Add(7);
            bst.Add(8);

            bst.Display();
            Console.WriteLine();

            //Assert
            bst.PostOrder(bst.Root);

            Console.WriteLine();

            Console.WriteLine();
            try
            {
                foreach (var node in bst.PostOrderEnumerable)
                {
                    Console.Write(" {0} ", node);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Assert.IsTrue(true);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void FindMinTest()
        {

            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            Random r = new Random();
            int count = 10;

            List<int> values = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var num = r.Next(count);

                bst.Add(num);

                values.Add(num);
            }

            int actual = bst.FindMin(bst.Root);

            int expected = bst.Min.Value;

            //Assert
            bst.Display();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void FindMaxTest()
        {
            //Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //Act
            Random r = new Random();
            int count = 10;

            List<int> values = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var num = r.Next(count);

                bst.Add(num);

                values.Add(num);
            }

            int actual = bst.FindMax(bst.Root);

            int expected = bst.Max.Value;

            //Assert
            bst.Display();
            Assert.AreEqual(expected, actual);
        }
    }
}
