using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.binarysearchtree
{
    /// <summary>
    /// Represents a BinarySearchTree<T>
    /// </summary>
    /// <typeparam name="T">Specifies the element type of the BinarySearchTree<T>.</typeparam>
    public class BinarySearchTree<T> : ICollection<T> where T : IComparable<T>
    {
        /// <summary>
        /// Traversing type
        /// </summary>
        /// <see cref="http://en.wikipedia.org/wiki/Tree_traversal#Types"/>
        public enum TraversalType
        {
            /// <summary>
            /// Depth-first - Inorder: Left child, Root, Right child
            /// </summary>
            InOrder = 0,

            /// <summary>
            /// Depth-first - Preorder: Root, Left child, Right child
            /// </summary>
            PreOrder = 1,

            /// <summary>
            /// Depth-first - Postorder: Left Child, Right child, Root
            /// </summary>
            PostOrder = 2,

            /// <summary>
            /// Breadth-first - Bylevel
            /// </summary>
            InLevels = 4
        }

        /// <summary>
        /// Gets the BinarySearchTree<T> root node
        /// </summary>
        public Node<T> Root { get; private set; }

        /// <summary>
        /// Get the BinarySearchTree<T> number of nodes
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Returns the BinarySearchTree<T> as IEnumerable<T> traversed in Inorder
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
                Stack<Node<T>> stack = new Stack<Node<T>>();
                Node<T> node = this.Root;

                bool isLeft = true;

                stack.Push(node);

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
                Stack<Node<T>> stack = new Stack<Node<T>>();
                Node<T> node = null;

                stack.Push(this.Root);

                while (stack.Count > 0)
                {
                    node = stack.Pop();

                    yield return node.Value;

                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }

                    if (node.Left != null)
                    {
                        stack.Push(node.Left);
                    }
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
                Stack<Node<T>> stack = new Stack<Node<T>>();
                Node<T> node = this.Root;

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

                Queue<Node<T>> queue = new Queue<Node<T>>();
                queue.Enqueue(this.Root);

                while (queue.Count > 0)
                {
                    Node<T> current = queue.Dequeue();
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

        public Node<T> Min {
            get
            {
                if (this.Root == null)
                {
                    return null;
                }

                Node<T> node = this.Root;

                //[ Iterative version ]
                while (node != null && node.Left != null)
                {
                    node = node.Left;
                }

                return node;
            }
        }

        public Node<T> Max
        {
            get
            {
                if (this.Root == null)
                {
                    return null;
                }

                Node<T> node = this.Root;

                //[ Iterative version ]
                while (node != null && node.Right != null)
                {
                    node = node.Right;
                }

                return node;
            }
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

            Node<T> result = Remove(this.Root, value);

            return (counter - this.Count >= 1) ? true : false;
        }
       
        /// <summary>
        /// In-Order: Left child, Root, Right child
        /// </summary>
        public void InOrder(Node<T> node)
        {

            if (node != null)
            {
                InOrder(node.Left);
                node.DisplayNode();
                InOrder(node.Right);
            }
        }

        /// <summary>
        /// Pre-Order: Root, Left child, Right child
        /// </summary>
        public void PreOrder(Node<T> node)
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
        public void PostOrder(Node<T> node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                node.DisplayNode();
            }
        }

        /// <summary>
        /// Breadth-first: Visit every node on a level before going to a lower level.
        /// </summary>
        /// <param name="node">Usually the BinarySearchTree<T> root node or some arbitrary node/></param>
        public void InLevels(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();
                current.DisplayNode();

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
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
        public void InLevelSpiral(Node<T> node) 
        {
            int level = GetLevels(node);

            bool reversed = false;

            for (int i = 0; i < level; i++)
            {
                GivenLevelSpiral(node, i, reversed);
                reversed = !reversed;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        //TODO: Move this to a new project called BinaryTree
        public void Mirror(Node<T> node)
        {
            if(node == null)
            {
                return;
            }
            else
            {
                Mirror(node.Left);
                Mirror(node.Right);

                Node<T> current = node.Left;
                node.Left = node.Right;
                node.Right = current;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        //BUG: 2487
        public bool IsBinarySearchTree(Node<T> node)
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
        ///  It starts at the tree root and explores the neighbor nodes first, before moving to the next level neighbours
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T FindMin(Node<T> node)
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
        public T FindMax(Node<T> node)
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
        private void Display(Node<T> node, String prefix = "")
        {
            if (node == null)
            {
                Console.WriteLine(prefix + "+- ");
                return;
            }

            Console.WriteLine(prefix + "+- " + node.Value);

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
        /// Recursive version of Level Order Traversal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <param name="level"></param>
        /// <param name="reversed"></param>
        private static void GivenLevelSpiral<T>(Node<T> node, int level, bool reversed) where T : IComparable<T>
        {
            if (node == null)
            {
                return;
            }

            if (level == 0)
            {
                Console.Write(" {0} ", node.Value);
            }

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

        /// <summary>
        /// Get the max level of a BinarySearchTree
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <returns></returns>
        private static int GetLevels<T>(Node<T> node) where T : IComparable<T>
        {
            if (node == null)
                return 0;

            int left = GetLevels(node.Left) + 1;
            int right = GetLevels(node.Right) + 1;

            return left < right ? right : left;
        }

        /// <summary>
        /// Add a new node
        /// </summary>
        /// <param name="node">Usually the BinarySearchTree<T> root node or some arbitrary node</param>
        /// <param name="value">The value to be added</param>
        /// <returns>Node<T></returns>
        private Node<T> Add(Node<T> node, T value)
        {
            if (node == null)
            {
                this.Count++;

                return new Node<T>(value);
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
        /// <param name="node">Usually the BinarySearchTree<T> root node or some arbitrary node</param>
        /// <param name="value">Node value which will be deleted</param>
        /// <returns>Node<T></returns>
        private Node<T> Remove(Node<T> node, T value)
        {
            if (node == null)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)            //if node.value is greater than value
            {
                node.Left= Remove(node.Left, value);
            }
            else if (node.Value.CompareTo(value) < 0)       //if node.value is lesser than value
            {
                node.Right= Remove(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                {
                    Node<T> right = node.Right;
                    
                    node = null;

                    this.Count--;

                    return right;
                }
                else if (node.Right == null)
                {
                    Node<T> left = node.Left;

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
        private bool Find(Node<T> node, T value)
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