/*
 * @autor: Some smart guy on internet
 * @date: 25/05/2015
 * @project: ArrayToBinarySearchTree
 * 
 */

using com.hack3rlife.datastructures;
using System.Collections.Generic;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// Extension method which implements conversion from a List to a BinarySearchTree (BST)
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="list">The input array</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <returns>A balanced <see cref="BinarySearchTree"/></returns>
        /// <see cref="http://www.geeksforgeeks.org/sorted-array-to-balanced-bst/"/>
        /// <!--Given a sorted array. Write a function that creates a Balanced Binary Search Tree using array elements.-->
        /// <![CDATA[
        /// Input:  int[] {1, 2, 3}
        /// Output: A Balanced BST
        ///      2
        ///    /  \
        ///   1    3 
        /// 
        /// Input: Array {1, 2, 3, 4}
        /// Output: A Balanced BST
        ///         3
        ///       /  \
        ///      2    4
        ///     /
        ///    1
        /// ]]>
        public static BinarySearchTree<int> ToBinarySearchTree(this IList<int> list, int start, int end)
        {
            var root = ToBinarySearchTreeNode(list, start,end);
            var bst = new BinarySearchTree<int>(root);
            return bst;
        }

        /// <summary>
        /// Recursive method to convert <para>list</para> into a <see cref="BinarySearchTreeNode"/>
        /// </summary>
        /// <param name="list">The input list</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <returns><see cref="BinarySearchTreeNode{int}"/></returns>
        private static BinarySearchTreeNode<int> ToBinarySearchTreeNode(this IList<int> list, int start, int end)
        {
            if (start > end)
                return null;

            //Get the middle element and make it root
            int mid = (start + end) >> 1;

            var root = new BinarySearchTreeNode<int>(list[mid]);

            //Recursively construct the left subtree and make it left child of root
            root.Left = ToBinarySearchTreeNode(list, start, mid - 1);

            //Recursively construct the right subtree and make it right child of root
            root.Right = ToBinarySearchTreeNode(list, mid + 1, end);

            return root;
        }

    }
}
