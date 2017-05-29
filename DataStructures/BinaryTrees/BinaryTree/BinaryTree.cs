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
        /// Symmetric Tree (Mirror Image of itself)
        /// Given a binary tree, check whether it is a mirror of itself.
        /// </summary>
        /// <param name="node">The root of the <see cref="BinaryTree{T}"/>.</param>
        /// <![CDATA[
        /// For example, this binary tree is symmetric:
        ///        1
        ///      /   \
        ///     2     2
        ///   / \   / \
        ///  3   4 4   3
        ///  
        /// But the following is not:
        ///     1
        ///    / \
        ///   2   2
        ///    \   \
        ///     3    3
        /// ]]>
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
        /// <![CDATA[
        ///       									6
        ///                                      /      \
        ///                                    3          5
        ///                                  /   \          \
        ///                                 2     5          4  
        ///                                      /   \
        ///                                     7     4
        /// There are 4 leaves, hence 4 root to leaf paths:
        /// Path Number
        /// 6->3->2                   632
        /// 6->3->5->7               6357
        /// 6->3->5->4               6354
        /// 6->5>4                    654   
        ///Answer = 632 + 6357 + 6354 + 654 = 13997 
        /// ]]>
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
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
        /// <returns>The max sum between to leaves if any; otherwise 0</returns>
        /// <see cref="http://algorithms.tutorialhorizon.com/given-a-binary-tree-find-the-maximum-path-sum-between-any-two-leaves/"/>
        /// <seealso cref="http://www.geeksforgeeks.org/find-maximum-path-sum-two-leaves-binary-tree/"/>
        public int MaxSumPathBetweenTwoleaves(BinaryTreeNode<int> node)
        {
            if (node == null)
                return 0;

            int max = int.MinValue;
            MaxSumPathBetweenTwoleavesHelper(node, ref max);

            return max;
        }

        /// <summary>
        /// Helper method to find the maximum path sum between two leaves of a binary tree
        /// </summary>
        /// <param name="node">TThe <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="max">The current max in the current recursion stack</param>
        /// <returns>The max sum between to leaves if any; otherwise 0</returns>
        private int MaxSumPathBetweenTwoleavesHelper(BinaryTreeNode<int> node, ref int max)
        {
            if (node == null)
                return 0;

            var left = MaxSumPathBetweenTwoleavesHelper(node.Left, ref max);
            var right = MaxSumPathBetweenTwoleavesHelper(node.Right, ref max);

            var currMax = left + right + node.Value;
            Debug.WriteLine("currMax: {0} + {1} + {2} = {3}", left, right, node.Value, currMax);

            if (max < currMax)
            {
                max = currMax;
                Debug.WriteLine("Max: {0}", max, node.Value);
            }

            var result = Math.Max(left, right) + node.Value;
            Debug.WriteLine("Current Sum: Max({0},{1}) + {2} = {3}", left, right, node.Value, result);

            return result;
        }


        /// <summary>
        /// Given a Binary Tree, find the maximum sum path from a leaf to root. 
        /// </summary>
        /// <![CDATA[
        ///  For example, in the following tree, there are three leaf to root paths 8->-2->10, -4->-2->10 and 7->10. The sums of these three paths are 16, 4 and 17 respectively. 
        ///  The maximum of them is 17 and the path for maximum is 7-> 10.
        ///                  10
        ///               /      \
        ///	            -2        7
        ///            /   \     
        ///	          8     -4    
        /// ]]>
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="curent"></param>
        /// <returns>The max sum</returns>
        /// <see cref="http://www.geeksforgeeks.org/find-the-maximum-sum-path-in-a-binary-tree/"/>
        public int MaxSumRootToLeaf(BinaryTreeNode<int> node)
        {
            if (node == null)
                return 0;

            return MaxSumRootToLeafHelper(node, 0);
        }

        /// <summary>
        /// Helper fuction to find the maximum sum leaf to root path in a Binary Tree
        /// </summary>
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="currSum"></param>
        /// <returns></returns>
        private int MaxSumRootToLeafHelper(BinaryTreeNode<int> node, int currSum)
        {
            if (node == null)
                return 0;

            currSum += node.Value;
            Debug.WriteLine("Current Sum: {0}", currSum);

            if (node.Left == null && node.Right == null)
            {
                Debug.WriteLine("Current Sum: {0} at leaf {1}", currSum, node.Value);
                return currSum;
            }

            var left = MaxSumRootToLeafHelper(node.Left, currSum);
            var right = MaxSumRootToLeafHelper(node.Right, currSum);

            var max = left > right ? left : right;

            Debug.WriteLine("Current Max Sum(left:{0}, rigth:{1}) = {2}", left, right, max);

            return max;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
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
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
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

        /// <summary>
        /// The diameter of a Binary Tree (sometimes called the width) is the number of nodes on the longest path between two leaves in the tree.
        /// The diameter of a tree T is the largest of the following quantities:
        /// 1. The diameter of T’s left subtree
        /// 2. The diameter of T’s right subtree
        /// 3. The longest path between leaves that goes through the root of T(this can be computed from the heights of the subtrees of T)
        /// </summary>
        /// <param name="node">he <see cref="BinaryTreeNode{T}"/></param>
        /// <returns>The Diamater of the tree.</returns>
        /// <see cref="http://www.geeksforgeeks.org/lowest-common-ancestor-binary-tree-set-1/"/>
        /// <seealso cref="http://algorithms.tutorialhorizon.com/diameter-of-a-binary-tree/"/>
        public int Diameter(BinaryTreeNode<T> node)
        {
            //base case
            if (node == null)
                return 0;

            //get left and right heigth
            int lheight = Height(node.Left);
            int rheight = Height(node.Right);

            Debug.WriteLine("Node: {0} lheight: {1} rheight: {2}", node.Value, lheight, rheight);

            // get the left and right
            int ldiameter = Diameter(node.Left);
            int rdiameter = Diameter(node.Right);

            Debug.WriteLine("Node: {0} ldiameter: {1} rdiameter: {2}", node.Value, ldiameter, rdiameter);

            int diameter = Math.Max(lheight + rheight + 1,    // Height of left subtree + height of right subtree + 1 
                         Math.Max(ldiameter,                // Diameter of left subtree
                        rdiameter));                        // Diameter of right subtree

            Debug.WriteLine("Node: {0} Diamater: {1}", node.Value, diameter);

            return diameter;
        }


        /// <summary>
        /// Find the Maximum Depth OR Height of a Binary Tree
        /// </summary>
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
        /// <returns>Height of a binary tree</returns>
        /// <see cref="http://algorithms.tutorialhorizon.com/find-the-maximum-depth-or-height-of-a-binary-tree/"/>
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
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
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
        /// Helper function to check if the given binary tree is a mirror of itself.
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
        /// <param name="root">The <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
        /// <param name="parent">The <see cref="BinaryTreeNode{T}"/></param>
        /// <returns>Inorder suc­ces­sor of node</returns>
        /// <see cref="http://algorithms.tutorialhorizon.com/inorder-successor-in-binary-tree/"/>
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
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
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
        /// <param name="node">The <see cref="BinaryTreeNode{T}"/></param>
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