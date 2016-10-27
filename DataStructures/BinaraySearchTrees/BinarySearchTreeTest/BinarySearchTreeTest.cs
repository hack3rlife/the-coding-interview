using System;
using System.Collections.Generic;
using System.Linq;
using com.hack3rlife.datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTreeTest
{

    [TestClass]
    public class BinarySearchTreeTest
    {
       
        

        [TestMethod]
        public void ContainsTest()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                bst.Add(r.Next());
            }

            bst.Add(5);

            //assert
            bst.Display();

            var expected = true;
            var actual = bst.Contains<int>(5);
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void InOrderTest()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                bst.Add(r.Next(10));
            }

            //assert
            foreach (var node in bst.InOrderEnumerable)
            {
                Console.Write(" {0} ", node);
            }
        }

        [TestMethod]
        public void PreOrderTest()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
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

            //assert
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
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
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

            //assert
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

            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
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

            //assert
            bst.Display();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void FindMaxTest()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            //act
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

            //assert
            bst.Display();
            Assert.AreEqual(expected, actual);
        }
    }
}
