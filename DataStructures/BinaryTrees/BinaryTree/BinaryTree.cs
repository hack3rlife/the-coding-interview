using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace com.hack3rlife.binarytree
{
    /// <summary>
    /// A binary tree is a tree data structure in which each node has at most two child nodes, usually distinguished as "left" and "right". 
    /// </summary>
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> _root;

        public BinaryTreeNode<T> Root
        {
            get { return _root; }
            set { _root = value; }
        }

        public BinaryTree()
        {
            this._root = null;
        }

        /// <summary>
        /// Find the Lowest Common Ancester 
        /// </summary>
        /// <param name="root">Binary Tree</param>
        /// <param name="p">BinaryTreeNode Node to found common parent with <para>q</para></param>
        /// <param name="q">BinaryTreeNode Node to found common parent with <para>p</para></param>
        /// <remarks>In graph theory and computer science, the lowest common ancestor (LCA) of two nodes v and w in a tree or directed acyclic graph (DAG) is the lowest (i.e. deepest) node
        /// that has both v and w as descendants, where we define each node to be a descendant of itself (so if v has a direct connection from w, w is the lowest common ancestor).</remarks>
        /// <see cref="https://en.wikipedia.org/wiki/Lowest_common_ancestor"/>
        /// <seealso cref="http://www.geeksforgeeks.org/lowest-common-ancestor-binary-tree-set-1/"/>
        public BinaryTreeNode<T> LowestCommonAncestor(BinaryTreeNode<T> root, BinaryTreeNode<T> p, BinaryTreeNode<T> q)
        {

            if (root == null)
                return null;

            if (root == p || root == q)
            {
                Debug.WriteLine("p or q is the root.  Root: {0} - p: {1} - q: {2}", root.Value, p.Value, q.Value);
                return root;
            }
            else
            {
                Debug.WriteLine("Getting the LCA of p and q in left subtree. Current node: {0}", root.Value);
                BinaryTreeNode<T> left = LowestCommonAncestor(root.Left, p, q);
                Debug.WriteLine("Getting the LCA of p and q in right subtree. Current node: {0}", root.Value);
                BinaryTreeNode<T> right = LowestCommonAncestor(root.Right, p, q);

                if (left != null && right != null)
                {
                    Debug.WriteLine("If p ({0}) or q ({1}) is in left  and other is in right", p.Value, q.Value);
                    Debug.WriteLine("then then root ({0}) it the LCA", root.Value);
                    return root;
                }
                else if (left != null)
                {
                    Debug.WriteLine("else if left ({0}) is not null, left is LCA", left.Value);
                    return left;
                }
                else if (right != null)
                {
                    Debug.WriteLine("else if right ({0}) is LCA", right.Value);
                    return right;
                }
                else
                {
                    Debug.WriteLine("There is no LCA");
                    return null;
                }
            }
        }

        public void LeftRigthToDownRightRepresentation(BinaryTreeNode<T> node)
        {
            if (node == null)
                return;

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(node);

            BinaryTreeNode<T> head = node;
            BinaryTreeNode<T> prev = null;

            while (true)
            {
                int count = queue.Count;

                if (count == 0)
                    break;

                prev = null;

                while (count > 0)
                {

                    BinaryTreeNode<T> current = queue.Dequeue();
                    //current.DisplayNode();

                    if (current.Left != null)
                        queue.Enqueue(current.Left);

                    if (current.Right != null)
                        queue.Enqueue(current.Right);


                    if (prev != null)
                    {
                        prev.Right = current;
                        prev.Left = null;
                    }
                    else
                    {
                        head.Left = current;
                        head = current;
                    }

                    current.Left = null;
                    prev = current;
                    count--;
                }

                prev.Right = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void Mirror(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Mirror(node.Left);
                Mirror(node.Right);

                BinaryTreeNode<T> current = node.Left;
                node.Left = node.Right;
                node.Right = current;
            }
        }

        public int SumOfAllLeaves(BinaryTreeNode<int> node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Value;

            return SumOfAllLeaves(node.Left) + SumOfAllLeaves(node.Right);
        }

        public int RootToLeafPathsSum(BinaryTreeNode<int> node, int val)
        {
            if (node == null)
                return 0;

            val = (val * 10 + node.Value);

            if (node.Left == null && node.Right == null)
                return val;

            return RootToLeafPathsSum(node.Left, val) + RootToLeafPathsSum(node.Right, val);
        }       

        public void RootToLeafPathsMaxSum(BinaryTreeNode<int> node, int curent, ref int max)
        {
            if (node == null)
                return;

            curent = curent + node.Value;

            if (node.Left == null && node.Right == null)
            {
                if (curent > max)
                {
                    max = curent;
                }
            }

            RootToLeafPathsMaxSum(node.Left, curent, ref max);
            RootToLeafPathsMaxSum(node.Right, curent, ref max);            
        }       

        /// <summary>
        /// Display the BinarySearchTree strcuture 
        /// </summary>
        public void Display(bool IsLeft = true)
        {
            if (IsLeft)
                DisplayLeftRight(this.Root);
            else
                DisplayDownRight(this.Root);
        }

        /// <summary>
        /// Based on http://stackoverflow.com/questions/1649027/how-do-i-print-out-a-tree-structure
        /// </summary>
        /// <param name="node">Usually BinarySearchTree<T> root</param>
        /// <param name="prefix">If wanted, prefix value to be appended</param>
        private void DisplayLeftRight(BinaryTreeNode<T> node, String prefix = "")
        {
            if (node == null)
            {
                Debug.WriteLine(prefix + "+ ");
                return;
            }

            Debug.WriteLine(prefix + "+ " + node.Value);

            DisplayLeftRight(node.Left, prefix + "|  ");
            DisplayLeftRight(node.Right, prefix + "|  ");
        }

        /// <summary>
        /// Based on http://stackoverflow.com/questions/1649027/how-do-i-print-out-a-tree-structure
        /// </summary>
        /// <param name="node">Usually BinarySearchTree<T> root</param>
        /// <param name="prefix">If wanted, prefix value to be appended</param>
        private void DisplayDownRight(BinaryTreeNode<T> node, String prefix = "")
        {
            if (node != null)
            {
                Debug.Write(prefix + node.Value);

                DisplayDownRight(node.Right, prefix + "-");
                Debug.WriteLine("");
                DisplayDownRight(node.Left, "");
            }

        }
    }
}