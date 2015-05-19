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

    }
        
}