using System;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    public static class BinarySearchTreeExtension
    {
        public static void InLevel<T>(this BinarySearchTreeNode<T> node) where T : IComparable<T>
        {
            Queue<BinarySearchTreeNode<T>> q = new Queue<BinarySearchTreeNode<T>>();
            q.Enqueue(node);

            while (q.Count > 0)
            {
                var tn = q.Dequeue();
                tn.DisplayNode();

                if (tn.Left != null)
                    q.Enqueue(tn.Left);
                if (tn.Right != null)
                    q.Enqueue(tn.Right);
            }
        }

        /// <summary>
        /// Modification of level order traversal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <see cref="http://www.geeksforgeeks.org/level-order-traversal-in-spiral-form/"/>
        /// <remarks>
        ///  To print the nodes in spiral order, nodes at different levels should be printed in alternating order. 
        ///  An additional Boolean variable ltr is used to change printing order of levels. If ltr is 1 then printGivenLevel() prints nodes from left to right 
        ///  else from right to left. Value of ltr is flipped in each iteration to change the order.
        /// </remarks>
        public static void InLevelSpiral<T>(this BinarySearchTreeNode<T> node) where T : IComparable<T>
        {
            int level = GetLevels(node);

            bool reversed = false;

            for (int i = 0; i < level; i++)
            {
                GivenLevelSpiral(node, i, reversed);
                reversed = !reversed;
            }
        }

        public static void FindKthLargestElements<T>(this BinarySearchTreeNode<T> node, int k, IList<T> list) where T : IComparable<T>
        {
            if (node != null)
            {
                FindKthLargestElements<T>(node.Right, k, list);

                if (list.Count < k)
                {
                    list.Add(node.Value);
                }

                FindKthLargestElements<T>(node.Left, k, list);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        //BUG: 2487
        public static bool IsBinarySearchTree<T>(this BinarySearchTreeNode<T> node) where T : IComparable<T>
        {
            if (node != null)
            {
                if (node.Left != null && node.Value.CompareTo(node.Left.Value) < 0)
                    return false;
                IsBinarySearchTree(node.Left);

                if (node.Right != null && node.Value.CompareTo(node.Right.Value) > 0)
                    return false;
                IsBinarySearchTree(node.Right);
            }

            return true;
        }

        /// <summary>
        /// Get the max level of a BinarySearchTree
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <returns></returns>
        private static int GetLevels<T>(BinarySearchTreeNode<T> node) where T : IComparable<T>
        {
            if (node == null)
                return 0;

            int left = GetLevels(node.Left) + 1;
            int right = GetLevels(node.Right) + 1;

            return left < right ? right : left;
        }

        /// <summary>
        /// Recursive version of Level Order Traversal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <param name="level"></param>
        /// <param name="reversed"></param>
        private static void GivenLevelSpiral<T>(BinarySearchTreeNode<T> node, int level, bool reversed) where T : IComparable<T>
        {
            if (node == null)
                return;

            if (level == 0)
                Console.Write(" {0} ", node.Value);

            if (level > 0)
            {
                if (reversed)
                {
                    GivenLevelSpiral(node.Left, level - 1, reversed);
                    GivenLevelSpiral(node.Right, level - 1, reversed);
                }
                else
                {
                    GivenLevelSpiral(node.Right, level - 1, reversed);
                    GivenLevelSpiral(node.Left, level - 1, reversed);
                }
            }
        }
    }
}
