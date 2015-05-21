using System;
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

        /// <summary>
        /// Display the BinarySearchTree strcuture 
        /// </summary>
        public void Display(bool IsLeft)
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
                Console.WriteLine(prefix + "+ ");
                return;
            }

            Console.WriteLine(prefix + "+ " + node.Value);

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
                Console.Write(prefix + node.Value);

                DisplayDownRight(node.Right, prefix + "-");
                Console.WriteLine();
                DisplayDownRight(node.Left, "");
            }

        }
    }
}