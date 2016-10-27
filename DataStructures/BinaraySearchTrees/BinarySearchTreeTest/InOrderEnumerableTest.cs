using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass]
    public class InOrderEnumerableTest
    {
        [TestMethod]
        public void BinarySearchTree_InOrderEnumerableTest_NoError()
        {
            //arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(50);
            bst.Add(30);
            bst.Add(20);
            bst.Add(40);
            bst.Add(70);
            bst.Add(60);
            bst.Add(80);

            //act
            var enumerable = bst.InOrderEnumerable;

            var actual = new List<int>();
            foreach (var item in enumerable)
            {
                actual.Add(item);
            }

            //assert
            var expected = new List<int>() { 20, 30, 40, 50, 60, 70, 80 };
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
