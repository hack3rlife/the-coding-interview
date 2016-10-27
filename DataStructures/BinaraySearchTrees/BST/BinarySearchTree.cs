using System;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// In computer science, binary search trees (BST), sometimes called ordered or sorted binary trees, are a particular type of containers: data structures that store "items" 
    /// (such as numbers, names etc.) in memory. They allow fast lookup, addition and removal of items, and can be used to implement either dynamic sets of items, or lookup tables that 
    /// allow finding an item by its key (e.g., finding the phone number of a person by name).
    /// 
    /// Binary search trees keep their keys in sorted order, so that lookup and other operations can use the principle of binary search: when looking for a key in a tree(or a place to 
    /// insert a new key), they traverse the tree from root to leaf, making comparisons to keys stored in the nodes of the tree and deciding, based on the comparison, to continue searching
    /// in the left or right subtrees.On average, this means that each comparison allows the operations to skip about half of the tree, so that each lookup, insertion or deletion takes time proportional to the logarithm of the number of items stored in the tree. This is much better than the linear time required to find items by key in an (unsorted) array, but slower than the corresponding operations on hash tables.
    /// </summary>
    /// <remarks>Even when the class is generic, the code is intended to manage numeric values (int, double, decimal, etc)</remarks>
    /// <typeparam name="{T}">Specifies the element type of the BinarySearchTree<T>.</typeparam>
    /// <see cref="https://en.wikipedia.org/wiki/Binary_search_tree"/>
    public class BinarySearchTree<T> : ICollection<T> where T : IComparable<T>
    {
        /// <summary>
        /// Gets the <see cref="BinarySearchTree{T}"/> root node
        /// </summary>
        public BinarySearchTreeNode<T> Root { get; private set; }

        /// <summary>
        /// Get the <see cref="BinarySearchTree{T}"/> number of nodes
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Returns the <see cref="BinarySearchTree{T}"/> as IEnumerable<T> traversed in Inorder
        /// </summary>
        /// <see cref="http://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/"/>
        /// <remarks>
        /// 1) Create an empty stack S.
        /// 2) Initialize current node as root
        /// 3) Push the current node to S and set current = current->left until current is NULL
        /// 4) If current is NULL and stack is not empty then 
        ///     a) Pop the top item from stack.
        ///     b) Print the popped item, set current = popped_item->right 
        ///     c) Go to step 3.
        /// 5) If current is NULL and stack is empty then we are done
        /// </remarks>
        public IEnumerable<T> InOrderEnumerable
        {
            get
            {
                var stack = new Stack<BinarySearchTreeNode<T>>();
                var node = this.Root;

                stack.Push(node);

                bool isLeft = true;

                while (stack.Count > 0)
                {
                    if (isLeft)
                    {
                        while (node.Left != null)
                        {
                            stack.Push(node);
                            node = node.Left;
                        }
                    }

                    yield return node.Value;

                    if (node.Right != null)
                    {
                        node = node.Right;
                        isLeft = true;
                    }
                    else
                    {
                        node = stack.Pop();
                        isLeft = false;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the BinarySearchTree<T> as IEnumerable<T> traversed in Preorder               ///     
        /// </summary>
        /// <see cref="http://www.geeksforgeeks.org/iterative-preorder-traversal/"/>
        /// <seealso cref="http://en.wikipedia.org/wiki/Tree_traversal#In-order_.28symmetric.29"/>
        /// <remarks>
        /// 1) Create an empty stack nodeStack and push root node to stack.
        /// 2) Do following while nodeStack is not empty.
        ///     a) Pop an item from stack and print it.
        ///     b) Push right child of popped item to stack
        ///     c) Push left child of popped item to stack
        /// </remarks>
        public IEnumerable<T> PreOrderEnumerable
        {
            get
            {
                Stack<BinarySearchTreeNode<T>> stack = new Stack<BinarySearchTreeNode<T>>();
                BinarySearchTreeNode<T> node = null;

                stack.Push(this.Root);

                while (stack.Count > 0)
                {
                    node = stack.Pop();

                    yield return node.Value;

                    if (node.Right != null)
                        stack.Push(node.Right);

                    if (node.Left != null)
                        stack.Push(node.Left);
                }
            }
        }

        /// <summary>
        /// Returns the BinarySearchTree<T> as IEnumerable<T> traversed in Postorder               
        /// </summary>
        /// <see cref="http://www.geeksforgeeks.org/iterative-postorder-traversal-using-stack/"/>
        /// <seealso cref="http://en.wikipedia.org/wiki/Tree_traversal#Post-order"/>
        /// <remarks>
        /// 1 Create an empty stack
        /// 2.1 Do following while root is not NULL
        ///     a) Push root's right child and then root to stack.
        ///     b) Set root as root's left child.
        /// 2.2 Pop an item from stack and set it as root.
        ///     a) If the popped item has a right child and the right child 
        ///          is at top of stack, then remove the right child from stack,
        ///         push the root back and set root as root's right child.
        ///     b) Else print root's data and set root as NULL.
        /// 3 Repeat steps 2.1 and 2.2 while stack is not empty.
        /// </remarks>
        public IEnumerable<T> PostOrderEnumerable
        {
            //#BUG: 2435
            get
            {
                Stack<BinarySearchTreeNode<T>> stack = new Stack<BinarySearchTreeNode<T>>();
                BinarySearchTreeNode<T> node = this.Root;

                do
                {
                    while (node != null)
                    {
                        if (node.Right != null)
                        {
                            stack.Push(node.Right);
                        }

                        stack.Push(node);

                        node = node.Left;
                    }

                    node = stack.Pop();

                    if (node.Right != null)
                    {
                        var peek = stack.Peek();

                        if (node.Right.Value.Equals(peek.Value))
                        {
                            var right = stack.Pop();
                            stack.Push(node);
                            node = node = node.Right;
                        }
                    }
                    else
                    {
                        yield return node.Value;
                        node = null;
                    }
                } while (stack.Count > 0);



            }
        }

        /// <summary>
        /// Returns the BinarySearchTree<T> as IEnumerable<T> traversed in levels               
        /// </summary>
        /// <see cref="http://en.wikipedia.org/wiki/Tree_traversal#Breadth-first_2"/>
        /// <seealso cref="http://en.wikipedia.org/wiki/Breadth-first_search"/>
        public IEnumerable<T> InLevelsEnumerable
        {
            get
            {
                if (Root == null) yield return default(T);

                Queue<BinarySearchTreeNode<T>> queue = new Queue<BinarySearchTreeNode<T>>();
                queue.Enqueue(this.Root);

                while (queue.Count > 0)
                {
                    BinarySearchTreeNode<T> current = queue.Dequeue();
                    yield return current.Value;

                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }

                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the node with the lowest value
        /// </summary>
        public BinarySearchTreeNode<T> Min
        {
            get
            {
                if (this.Root == null)
                {
                    return null;
                }

                BinarySearchTreeNode<T> node = this.Root;

                //[ Iterative version ]
                while (node != null && node.Left != null)
                {
                    node = node.Left;
                }

                return node;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public BinarySearchTreeNode<T> Max
        {
            get
            {
                if (this.Root == null)
                {
                    return null;
                }

                BinarySearchTreeNode<T> node = this.Root;

                //[ Iterative version ]
                while (node != null && node.Right != null)
                {
                    node = node.Right;
                }

                return node;
            }
        }

        /// <summary>
        /// Creates a new instance of type <see cref="BinarySearchTree{T}"/>
        /// </summary>
        public BinarySearchTree()
        {
            this.Root = null;
            this.Count = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public BinarySearchTree(BinarySearchTreeNode<T> root)
        {
            this.Root = root;
        }

        /// <summary>
        /// Add a new node to the BST
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(T value)
        {
            this.Root = Add(this.Root, value);
        }

        /// <summary>
        /// Remove a node from the BST
        /// </summary>
        /// <see cref="http://en.wikipedia.org/wiki/Binary_search_tree#Deletion"/>
        /// <param name="value">Value to be deleted</param>
        /// <returns></returns>
        /// <remarks>
        /// There are three possible cases to consider
        ///   1. Node to be deleted is leaf
        ///   2. Node to be deleted has only one child
        ///   3. Node to be deleted has two children
        /// </remarks>
        public bool Remove(T value)
        {
            if (this.Root == null)
            {
                return false;
            }

            int counter = this.Count;

            BinarySearchTreeNode<T> result = Remove(this.Root, value);

            return (counter - this.Count >= 1) ? true : false;
        }

        /// <summary>
        /// In-Order: Left child, Root, Right child
        /// </summary>
        public void InOrder(BinarySearchTreeNode<T> node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                node.DisplayNode();
                ToList();
                InOrder(node.Right);
            }
        }

        /// <summary>
        /// Pre-Order: Root, Left child, Right child
        /// </summary>
        public void PreOrder(BinarySearchTreeNode<T> node)
        {
            if (node != null)
            {
                node.DisplayNode();
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        /// <summary>
        /// Post-Order: Left Child, Right child, Root
        /// </summary>
        public void PostOrder(BinarySearchTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                node.DisplayNode();
            }
        }             

        public IList<T> ToList()
        {
            if (this.Root == null)
                return null;

            var list = new List<T>();
            foreach (var item in InLevelsEnumerable)
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        ///  It starts at the tree root and explores the neighbor nodes first, before moving to the next level neighbours
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T FindMin(BinarySearchTreeNode<T> node)
        {
            if (node != null && node.Left == null)
            {
                return node.Value;
            }
            else
            {
                return FindMin(node.Left);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T FindMax(BinarySearchTreeNode<T> node)
        {
            if (node != null && node.Right == null)
            {
                return node.Value;
            }
            else
            {
                return FindMax(node.Right);
            }


        }

        /// <summary>
        /// Clear the BinarySearchTree<T> and reset the counter to 0
        /// </summary>
        public void Clear()
        {
            this.Count = 0;
            this.Root = null;
        }

        /// <summary>
        /// Verify if the BinarySearchTree<T> contains the value passed as a parameter
        /// </summary>
        /// <param name="value">Value to be searched in the BinarySearchTree<T></param>
        /// <returns>True if there is a match; ohterwise false</returns>
        public bool Contains(T value)
        {
            return Find(this.Root, value);
        }

        public T FindSuccesor(BinarySearchTreeNode<T> root, BinarySearchTreeNode<T> node)
        {
            if (node.Right != null)
                return FindMin(node.Right);

            T succ = default(T);
             
            while (root != null)
            {
                if(node.Value.CompareTo(root.Value) < 0)        //node.Value < root.Value
                {
                    succ = root.Value;
                    root = root.Left;
                }else if(node.Value.CompareTo(root.Value) > 0)
                {
                    root = root.Right;
                }
                else
                {
                    break;
                }
            }

            return succ;
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>Returns an enumerator that iterates through a collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return InOrderEnumerable.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the BinarySearchTree<T> as a collection.
        /// </summary>
        /// <returns>Returns an enumerator that iterates through the BinarySearchTree<T> as a collection.</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Display the BinarySearchTree strcuture 
        /// </summary>
        public void Display()
        {
            Display(this.Root);
        }

        /// <summary>
        /// Based on http://stackoverflow.com/questions/1649027/how-do-i-print-out-a-tree-structure
        /// </summary>
        /// <param name="node">Usually BinarySearchTree<T> root</param>
        /// <param name="prefix">If wanted, prefix value to be appended</param>
        private void Display(BinarySearchTreeNode<T> node, String prefix = "")
        {
            if (node == null)
            {
                System.Diagnostics.Debug.WriteLine(prefix + "+- ");
                return;
            }

            System.Diagnostics.Debug.WriteLine(prefix + "+- " + node.Value);

            Display(node.Left, prefix + "|  ");
            Display(node.Right, prefix + "|  ");
        }

        /// <summary>
        /// Copies the traversed (Inorder) elements of the BinarySeearchTree<T> to an array, starting at arrayIndex.
        /// </summary>
        /// <param name="array">Array which is the destination of the elements copied from BinarySeearchTree<T></param>
        /// <param name="arrayIndex">Zero-based index in array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            CopyTo(array, arrayIndex, TraversalType.InOrder);
        }

        /// <summary>
        /// Copies the traversed elements of the BinarySeearchTree<T> to an array, starting at arrayIndex.
        /// </summary>
        /// <param name="array">Array which is the destination of the elements copied from BinarySeearchTree<T></param>
        /// <param name="arrayIndex">Zero-based index in array at which copying begins.</param>
        /// <param name="type">TraversalType</param>
        public void CopyTo(T[] array, int index, TraversalType type)
        {
            IEnumerable<T> ienumerable = null;

            switch (type)
            {
                case TraversalType.InOrder:
                    ienumerable = this.InOrderEnumerable;
                    break;
                case TraversalType.PreOrder:
                    ienumerable = this.PreOrderEnumerable;
                    break;
                case TraversalType.PostOrder:
                    break;
                case TraversalType.InLevels:
                    ienumerable = this.InLevelsEnumerable;
                    break;
                default:
                    break;
            }

            foreach (T item in ienumerable)
            {
                array[index++] = item;
            }
        }

        /// <summary>
        /// Will throw NotImplementedException
        /// </summary>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Adds a new node
        /// </summary>
        /// <param name="node">The <see cref="BinarySearchTreeNode{T}"/></param>
        /// <param name="value">The <see cref="T"/> value</param>
        /// <returns><see cref="BinarySearchTreeNode{T}"/></returns>
        private BinarySearchTreeNode<T> Add(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
            {
                this.Count++;

                node = new BinarySearchTreeNode<T>(value);
            }
            else if (node.Value.CompareTo(value) > 0) //if node.Value > value
            {
                node.Left = Add(node.Left, value);
            }
            else if (node.Value.CompareTo(value) <= 0) //if node.Value <= value
            {
                node.Right = Add(node.Right, value);
            }

            return node;
        }

        /// <summary>
        /// Removes the first node wich matches the value passed as parameter
        /// </summary>
        /// <param name="node">The <see cref="BinarySearchTreeNode{T}"/></param>
        /// <param name="value">Node value which will be deleted</param>
        /// <returns><see cref="BinarySearchTreeNode{T}"/></returns>
        private BinarySearchTreeNode<T> Remove(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)            //if node.value is greater than value
            {
                node.Left = Remove(node.Left, value);
            }
            else if (node.Value.CompareTo(value) < 0)       //if node.value is lesser than value
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                {
                    var right = node.Right;

                    node = null;

                    this.Count--;

                    return right;
                }
                else if (node.Right == null)
                {
                    var left = node.Left;

                    node = null;

                    this.Count--;

                    return left;
                }
                else
                {

                    T successor = FindMin(node.Right);

                    node.Value = successor;

                    node.Right = Remove(node.Right, successor);
                }
            }

            return node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool Find(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
                return false;
            else if (node.Value.CompareTo(value) == 0)
                return true;
            else if (node.Value.CompareTo(value) == 1)
                return Find(node.Left, value);
            else if (node.Value.CompareTo(value) == -1)
                return Find(node.Right, value);
            else
                return false;
        }       
    }
}