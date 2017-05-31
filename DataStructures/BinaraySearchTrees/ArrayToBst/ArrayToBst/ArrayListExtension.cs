/*
 * @autor: Some smart guy on internet
 * @date: 25/05/2015
 * @project: ArrayToBinarySearchTree
 * 
 */

using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Extension method which implements conversion from a List to a BinarySearchTree (BST)
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Sorted Array to Balanced BST
        /// </summary>
        /// <param name="list">The input array</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <returns>A balanced <see cref="BinarySearchTree"/></returns>
        /// <see cref="http://www.geeksforgeeks.org/sorted-array-to-balanced-bst/"/>
        /// <![CDATA[
        /// Given a sorted array. Write a function that creates a Balanced Binary Search Tree using array elements.
        /// 
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
        ///     /`
        ///    1
        /// ]]>
        public static BinarySearchTree<int> ToBinarySearchTree(this IList<int> list)
        {           
            var root = ToBst(list, 0, list.Count - 1);
            var bst = new BinarySearchTree<int>(root);
            return bst;
        }

        /// <summary>
        /// Create binary tree in level order from array
        /// </summary>
        /// <![CDATA[
        /// Given an array level-order traversals of a Binary Tree, construct the Binary Tree.
        /// 
        /// Input:  int[] {1, 2, 3}
        /// Output: In Level Binary Tree
        ///      1
        ///    /  \
        ///   2    3 
        /// 
        /// Input: Array {1, 2, 3, 4}
        /// Output: In Level Binary Tree
        ///         1
        ///       /  \
        ///      2    3
        ///     /`
        ///    4
        /// ]]>
        /// <param name="list"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/construct-tree-inorder-level-order-traversals/"/>
        public static BinaryTree<int> ToBinaryTreeInLevels(this IList<int> list)
        {

            var root = ToBtInLevels(list);
            var bt = new BinaryTree<int>(root);
            return bt;
        }

        /// <summary>
        /// Recursive method to convert <para>list</para> into a <see cref="BinarySearchTreeNode"/>
        /// </summary>
        /// <param name="list">The input list</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <returns><see cref="BinarySearchTreeNode{int}"/></returns>
        private static BinarySearchTreeNode<int> ToBst(this IList<int> list, int start, int end)
        {
            if (start > end)
                return null;

            //Get the middle element and make it root
            int mid = (start + end) >> 1;

            var root = new BinarySearchTreeNode<int>(list[mid]);

            //Recursively construct the left subtree and make it left child of root
            root.Left = ToBst(list, start, mid - 1);

            //Recursively construct the right subtree and make it right child of root
            root.Right = ToBst(list, mid + 1, end);

            return root;
        }

        /// <summary>
        /// Helper method to create a <see cref="BinarySearchTree{T}"/> from an array in level order
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static BinaryTreeNode<int> ToBtInLevels(this IList<int> list)
        {
            if (list == null || list.Count == 0)
                return null;

            var root = new BinaryTreeNode<int>(list[0]);

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(root);

            int count = list.Count;
            int i = 1;

            while (i < count)
            {
                var node = q.Dequeue();

                node.Left = new BinaryTreeNode<int>(list[i++]);

                q.Enqueue(node.Left);

                if (i < count)
                {
                    node.Right = new BinaryTreeNode<int>(list[i++]);
                    q.Enqueue(node.Right);
                }
            }

            return root;
        }

    }
}
