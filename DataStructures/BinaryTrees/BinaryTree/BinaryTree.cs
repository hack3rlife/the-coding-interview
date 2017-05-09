using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// A binary tree is a tree data structure in which each node has at most two child nodes, usually distinguished as "left" and "right". 
    /// 
    /// In computing, binary trees are seldom used solely for their structure. Much more typical is to define a labeling function on the nodes, which associates some value to each node.
    /// Binary trees labelled this way are used to implement binary search trees and binary heaps, and are used for efficient searching and sorting. 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Binary_tree"/>
    public class BinaryTree<T>
    {
        /// <summary>
        /// The <see cref="BinaryTreeNode{T}"/> which holds the structure of tree
        /// </summary>
        public BinaryTreeNode<T> Root { get; set; }

        private List<T> _inorder;

        public List<T> InOderList
        {
            get
            {
                if (Root != null && _inorder.Count == 0)
                {
                    _inorder = new List<T>();
                    InOrder(Root);
                }

                return _inorder;
            }
        }

        public BinaryTree()
        {
            _inorder = new List<T>();
        }

        /// <summary>
        /// Find the Lowest Common Ancester 
        /// </summary>
        /// <param name="node">Normally, the <see cref="BinaryTree{T}.Root"/></param>
        /// <param name="p">The <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="q">The <see cref="BinaryTreeNode{T}"/></param>
        /// <returns>The <see cref="BinaryTreeNode{T}"/> which is the LCA to <paramref name="p"/> and <paramref name="q"/></returns>
        /// <remarks>In graph theory and computer science, the lowest common ancestor (LCA) of two nodes v and w in a tree or directed acyclic graph (DAG) is the lowest (i.e. deepest) node
        /// that has both v and w as descendants, where we define each node to be a descendant of itself (so if v has a direct connection from w, w is the lowest common ancestor).</remarks>
        /// <see cref="https://en.wikipedia.org/wiki/Lowest_common_ancestor"/>
        /// <seealso cref="http://www.geeksforgeeks.org/lowest-common-ancestor-binary-tree-set-1/"/>
        public BinaryTreeNode<T> LowestCommonAncestor(BinaryTreeNode<T> node, BinaryTreeNode<T> p, BinaryTreeNode<T> q)
        {
            if (node == null)
                return null;

            if (node == p || node == q)
            {
                Debug.WriteLine("p or q is the root.  Root: {0} - p: {1} - q: {2}",
                    node.Value,
                    p != null ? p.Value : default(T),
                    q != null ? q.Value : default(T));
                return node;
            }
            else
            {
                Debug.WriteLine("Getting the LCA of p and q in left subtree. Current node: {0}", node.Value);
                BinaryTreeNode<T> left = LowestCommonAncestor(node.Left, p, q);
                Debug.WriteLine("Getting the LCA of p and q in right subtree. Current node: {0}", node.Value);
                BinaryTreeNode<T> right = LowestCommonAncestor(node.Right, p, q);

                if (left != null && right != null)
                {
                    Debug.WriteLine("If p ({0}) or q ({1}) is in left  and other is in right", p.Value, q.Value);
                    Debug.WriteLine("then then root ({0}) it the LCA", node.Value);
                    return node;
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

        /// <summary>
        /// An empty tree is height-balanced. A non-empty binary tree T is balanced if: 
        ///     1.  Left subtree of T is balanced
        ///     2.  Right subtree of T is balanced
        ///     3.  The difference between heights of left subtree and right subtree is not more than 1.
        /// </summary>
        /// <param name="node">The <see cref="BinaryTree{T}.Root"/></param>
        /// <returns>Returns true if difference between heights is not more than 1 and left and right subtrees are balanced, otherwise return false.</returns>
        /// <seealso cref="http://algorithms.tutorialhorizon.com/find-whether-if-a-given-binary-tree-is-balanced/"/>
        public bool IsBalanced(BinaryTreeNode<T> node)
        {
            if (node == null)
                return false;

            return CheckIsBalanced(node) > 0 ? true : false;
        }

        /// <summary>
        /// Check if the root is symetric or not.
        /// </summary>
        /// <param name="node">The root of the <see cref="BinaryTree{T}"/>.</param>
        /// <returns>True if the <see cref="BinaryTree{T}"/> is symetric; otherwise false.</returns>
        /// < cref="http://www.geeksforgeeks.org/symmetric-tree-tree-which-is-mirror-image-of-itself/"/>
        public bool IsSymetric(BinaryTreeNode<T> root)
        {
            if (root == null)
                return false;

            return CheckIsSymetric(root.Left, root.Right);
        }

        /// <summary>
        /// Given a Binary tree (Not binary Search Tree ), find the inorder suc­ces­sor of a node.
        /// </summary>
        /// <param name="root"></param>
        /// <remarks>Inorder suc­ces­sor of a node is the next node in the inorder tra­ver­sal of the tree. For the last node in a tree, inorder 
        /// suc­ces­sor will be NULL</remarks>
        /// <see cref="http://algorithms.tutorialhorizon.com/inorder-successor-in-binary-tree/"/>
        /// <returns>Inorder suc­ces­sor of node.</returns>
        public BinaryTreeNode<T> FindSuccesor(BinaryTreeNode<T> root, BinaryTreeNode<T> node)
        {
            if (root == null)
                return null;

            return FindSuccesor(root, node, null);
        }

        /// <summary>
        /// Mirror of a Binary Tree T is another Binary Tree M(T) with left and right children of all non-leaf nodes interchanged.
        /// </summary>
        /// <param name="node">Normally, the <see cref="BinaryTree{T}.Root"/></param>
        /// <see cref="http://www.geeksforgeeks.org/write-an-efficient-c-function-to-convert-a-tree-into-its-mirror-tree/"/>
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

        /// <summary>
        /// Sums all the values stored in the each leaf of the <see cref="BinaryTree{T}"/>
        /// </summary>
        /// <param name="node">Normally, the <see cref="BinaryTree{T}.Root"/></param>
        /// <returns>The sum of all the values stored in the all the leaves of the <see cref="BinaryTree{T}"/></returns>
        /// <see cref="http://www.geeksforgeeks.org/find-sum-left-leaves-given-binary-tree/"/>
        public int SumOfAllLeaves(BinaryTreeNode<int> node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Value;

            return SumOfAllLeaves(node.Left) + SumOfAllLeaves(node.Right);
        }

        /// <summary>
        /// Given a binary tree, where every node value is a Digit from 1-9 .Find the sum of all the numbers which are formed from root to leaf paths.
        /// </summary>
        /// <param name="node">Usually, the <see cref="BinaryTree{T}.Root"/></param>
        /// <param name="sum"></param>
        /// <returns>The sum of all the numbers which are formed from root to leaf paths.</returns>
        /// <see cref=">http://www.geeksforgeeks.org/sum-numbers-formed-root-leaf-paths/"/>
        public int RootToLeafPathsSum(BinaryTreeNode<int> node, int sum)
        {
            if (node == null)
                return 0;

            sum = (sum * 10 + node.Value);

            if (node.Left == null && node.Right == null)
                return sum;

            return RootToLeafPathsSum(node.Left, sum) + RootToLeafPathsSum(node.Right, sum);
        }

        /// <summary>
        /// Given a binary tree in which each node element contains a number. Find the maximum possible sum from one leaf node to another.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="curent"></param>
        /// <returns>The max sum</returns>
        /// <see cref="http://www.geeksforgeeks.org/find-maximum-path-sum-two-leaves-binary-tree/"/>
        public int MaxPathSum(BinaryTreeNode<int> node, int curent)
        {
            if (node == null)
                return 0;

            return MaxPathSumHelper(node, curent);
        }

        private int MaxPathSumHelper(BinaryTreeNode<int> node, int curent)
        {
            if (node == null)
                return 0;

            curent += node.Value;

            if (node.Left == null && node.Right == null)
                return curent;

            var left = MaxPathSumHelper(node.Left, curent);
            var right = MaxPathSumHelper(node.Right, curent);

            return left > right ? left : right;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
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
        /// Serialize and Deserialize a Binary Tree: A simple solution is to store both Inorder and Preorder traversals. This solution requires 
        /// space twice the size of Binary Tree.  We can save space by storing Preorder traversal and a marker for NULL pointers.
        /// </summary>
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="list">The storage list</param>
        /// <see cref="http://www.geeksforgeeks.org/serialize-deserialize-binary-tree/"/>
        public void Serialize(BinaryTreeNode<int> node, IList<int> list)
        {
            if (node == null)
            {
                list.Add(-1);
                Debug.Write(string.Format(" {0} ", -1));

                return;
            }

            list.Add(node.Value);
            Debug.Write(string.Format(" {0} ", node.Value));

            Serialize(node.Left, list);
            Serialize(node.Right, list);

        }

        /// <summary>
        /// Serialize and Deserialize a Binary Tree: Deserialization can be done by simply reading data from file one by one.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/serialize-deserialize-binary-tree/"/>
        public BinaryTreeNode<int> Deserialize(IList<int> input, ref int index)
        {
            if (input == null ||
                input[index] == -1 ||
                index == input.Count)
            {
                index += 1;
                return null;
            }

            var root = new BinaryTreeNode<int>(input[index]);
            index += 1;

            root.Left = Deserialize(input, ref index);
            root.Right = Deserialize(input, ref index);

            return root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void InOrder(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                _inorder.Add(node.Value);
                node.DisplayNode();
                InOrder(node.Right);
            }
        }

        public int Diameter(BinaryTreeNode<T> node)
        {
            //base case
            if (node == null)
                return 0;

            //get left and rigth heigth
            int lheight = Height(node.Left);
            int rheight = Height(node.Right);

            Debug.WriteLine("Node: {0} lheight: {1} rheight: {2}", node.Value, lheight, rheight);

            int ldiameter = Diameter(node.Left);
            int rdiameter = Diameter(node.Right);

            Debug.WriteLine("Node: {0} ldiameter: {1} rdiameter: {2}", node.Value, ldiameter, rdiameter);

            int result = Math.Max(lheight + rheight, Math.Max(ldiameter, rdiameter));

            Debug.WriteLine("Node: {0} result: {1}", node.Value, result);

            return result;
        }


        public int Height(BinaryTreeNode<T> node)
        {
            if (node == null)
                return 0;

            return 1 + Math.Max(Height(node.Left), Height(node.Right));
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
        /// Helper function to know if the tree is balanced or not.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>Returns -1 if the tree is not balanced; otherwise the height of the tree</returns>
        private int CheckIsBalanced(BinaryTreeNode<T> node)
        {
            if (node == null)
                return 0;

            var left = CheckIsBalanced(node.Left);
            if (left == -1)
                return -1;

            var right = CheckIsBalanced(node.Right);
            if (right == -1)
                return -1;

            var height = Math.Abs(left - right);

            if (height > 1)
                return -1;

            return 1 + Math.Max(left, right);
        }

        /// <summary>
        /// Helper function to check if the root is symetric or not.
        /// </summary>
        /// <param name="left">The left <see cref="BinaryTreeNode{T}"/>.</param>
        /// <param name="right">The right <see cref="BinaryTreeNode{T}.</param>
        /// <returns>True if the <see cref="BinaryTree{T}"/> is symetric; otherwise false.</returns>
        private bool CheckIsSymetric(BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left != null && right != null && left.Value.Equals(right.Value))
            {
                return CheckIsSymetric(left.Left, right.Right)
                    && CheckIsSymetric(left.Right, right.Left);
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        private BinaryTreeNode<T> FindLeftMostNode(BinaryTreeNode<T> right)
        {
            if (right.Left == null)
                return right;

            return FindLeftMostNode(right.Left);

        }

        /// <summary>
        /// Case 1: If the <para>node</para> has a right child then its inorder suc­ces­sor will be the left most ele­ment in the right sub tree of <para>node</para>.
        /// Case 2: 
        /// Case 3: if <para>node</para> is the right most node in the tree then its inorder suc­ces­sor will be NULL.
        /// </summary>
        /// <param name="root">The root</param>
        /// <param name="node">The node</param>
        /// <param name="parent">The parent node</param>
        /// <returns>Inorder suc­ces­sor of node</returns>
        private BinaryTreeNode<T> FindSuccesor(BinaryTreeNode<T> root, BinaryTreeNode<T> node, BinaryTreeNode<T> parent)
        {
            //base case
            if (root == null)
                return root;

            if (root == node)
            {
                if (root.Right != null)
                    return FindLeftMostNode(root.Right);

                return parent;
            }
            else
            {
                var curr = FindSuccesor(root.Left, node, root);

                if (curr != null)
                    return curr;

                return FindSuccesor(root.Right, node, parent);
            }
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

        ////public bool IsBalanced(BinaryTreeNode<T> node)
        ////{
        ////    if (node == null)
        ////        return true;

        ////    var left = GetHeigth(node.Left);
        ////    var right = GetHeigth(node.Right);

        ////    if (Math.Abs(left - right) <= 1
        ////        && IsBalanced(node.Left)
        ////        && IsBalanced(node.Right))
        ////    {
        ////        return true;
        ////    }

        ////    return false;
        ////}

        ////private int GetHeigth(BinaryTreeNode<T> node)
        ////{
        ////    if (node == null)
        ////        return 0;


        ////    return 1 + GetHeigth(node.Left) + GetHeigth(node.Right);
        ////}
    }
}