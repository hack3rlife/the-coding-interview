using System.Collections;
using com.hack3rlife.datastructures;
using System.Collections.Generic;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// 
    /// </summary>
    public static class ListExtension
    {
        public static BinarySearchTree<int> ToBinarySearchTree(this IList<int> list, int start, int end)
        {
            var root = ToBinarySearchTreeNode(list, start,end);
            var bst = new BinarySearchTree<int>(root);
            return bst;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static BinarySearchTreeNode<int> ToBinarySearchTreeNode(this IList<int> list, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) >> 1;

            var root = new BinarySearchTreeNode<int>(list[mid]);

            var left = ToBinarySearchTreeNode(list, start, mid - 1);
            root.Left = left;

            var right = ToBinarySearchTreeNode(list, mid + 1, end);
            root.Right = right;

            return root;
        }

    }
}
