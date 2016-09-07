using System;

namespace com.hack3rlife.datastructures
{
    public static class LinkedListExtension
    {
        /// <summary>
        /// Finds and returns the <see cref="Node{T}"/> which is the nth position from the last  of the LinkedList 
        /// </summary>
        /// <param name="list">The input list</param>
        /// <param name="kth">The kth position</param>
        /// <returns>The <see cref="Node{T}"/> in the kth position from the last; otherwise </returns>
        public static LinkedListNode FindKth(this LinkedList list, int kth)
        {
            if (list.Head != null && kth > 0)
            {
                LinkedListNode current = list.Head;
                LinkedListNode nth = list.Head;

                while (current != null)
                {
                    if (kth > 0)
                    {
                        current = current.Next;
                        kth--;
                    }
                    else
                    {
                        current = current.Next;
                        nth = nth.Next;
                    }
                }

                return kth == 0 ? nth : null;
            }

            return null;
        }

        /// <summary>
        /// Recursive method to merge two sorted linked lists
        /// </summary>
        /// <param name="list1">The sorted list1</param>
        /// <param name="list2">The sorted list2</param>
        /// <returns>A sorted list</returns>
        /// <see cref="http://stackoverflow.com/questions/10707352/interview-merging-two-sorted-singly-linked-list"/>
        /// <seealso cref="http://www.geeksforgeeks.org/merge-two-sorted-linked-lists/"/>
        public static LinkedListNode MergeRecursive(this LinkedListNode list1, LinkedListNode list2)
        {
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            if (list1.Value < list2.Value)
            {
                list1.Next = MergeRecursive(list1.Next, list2);
                return list1;
            }
            else
            {
                list2.Next = MergeRecursive(list1, list2.Next);
                return list2;
            }
        }

        /// <summary>
        /// Iterative method to merge two sorted linked lists
        /// </summary>
        /// <param name="list1">The sorted list1</param>
        /// <param name="list2">The sorted list2</param>
        /// <returns>A sorted list</returns>
        /// <see cref="http://stackoverflow.com/questions/10707352/interview-merging-two-sorted-singly-linked-list"/>
        /// <seealso cref="http://www.geeksforgeeks.org/merge-two-sorted-linked-lists/"/>
        public static LinkedListNode MergeIterative(this LinkedListNode list1, LinkedListNode list2)
        {
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            LinkedListNode node;
            if (list1.Value < list2.Value)
            {
                node = list1;
            }
            else
            {
                node = list2;
                list2 = list1;
                list1 = node;
            }

            while (list1.Next != null && list2 != null)
            {
                if (list1.Next.Value > list2.Value)
                {
                    LinkedListNode tmp = list1.Next;
                    list1.Next = list2;
                    list2 = tmp;
                }

                list1 = list1.Next;
            }

            if (list1.Next == null)
                list1.Next = list2;

            return node;
        }

        /// <summary>
        /// Reverse a <see cref="LinkedList{T}"/> (Iterative version)
        /// </summary>
        /// <param name="list">The <see cref="LinkedList{T}"/> </param>
        public static void ReverseIterative(this LinkedList list)
        {
            if (list.Head != null)
            {
                LinkedListNode previous = null;
                LinkedListNode current = list.Head;
                LinkedListNode next = null;

                while (current != null)
                {
                    next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }

                list.Head = previous;
                list.Tail = current;
            }
        }

        /// <summary>
        /// Reverse a <see cref="LinkedList{T}"/> (Recursive version)
        /// </summary>
        /// <param name="list">The <see cref="LinkedList{T}"/></param>
        /// <param name="current">The current <see cref="LinkedList{T}"/></param>
        public static void ReverseRecursive(this LinkedList list, LinkedListNode current)
        {
            if (current.Next == null)
            {
                list.Head = current;
                return;
            }

            ReverseRecursive(list, current.Next);

            LinkedListNode node = current.Next;
            current.Next = null;
            node.Next = current;
        }

        /// <summary>
        /// Remove duplicates from an unsorted LinkedList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void RemoveDulicatesUnsorted(this LinkedList list)
        {
            if (list.Head != null)
            {
                LinkedListNode current = list.Head;

                while (current != null)
                {
                    LinkedListNode node = current.Next;

                    while (node != null)
                    {
                        if (current.Value.Equals(node.Value))
                        {
                            node.Next = node.Next.Next;
                        }
                        else
                        {
                            node = node.Next;
                        }
                    }

                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Remove duplicates from an sorted LinkedList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void RemoveDuplicatesSorted(this LinkedList list)
        {
            if (list.Head != null)
            {
                LinkedListNode current = list.Head;

                while (current.Next != null)
                {
                    if (current.Value.Equals(current.Next.Value))
                    {
                        current = current.Next.Next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        /// <summary>
        /// Given a singly linked list, rotate the linked list counter-clockwise by k nodes
        /// </summary>
        /// <param name="list">LinkedList</param>
        /// <param name="k">Number of times the LinkedList is going to be rotated</param>
        public static void Rotate(this LinkedList list, int k)
        {
            if (list.Head == null)
                return;

            if (list.Count < k)
                return;

            LinkedListNode current = list.Head;
            LinkedListNode kthnode = null;

            while (current.Next != null)
            {
                if (k == 1)
                    kthnode = current;

                current = current.Next;
                k--;
            }

            current.Next = list.Head;
            list.Head = kthnode.Next;
            kthnode.Next = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void SwapConsecutives(this LinkedList list)
        {
            if (list.Head != null && list.Head.Next != null)
            {
                LinkedListNode current = list.Head;
                list.Head = current.Next;
                current.Next = list.Head.Next;
                list.Head.Next = current;

                while (current.Next != null && current.Next.Next != null)
                {
                    LinkedListNode temp = current.Next;
                    current.Next = current.Next.Next;
                    temp.Next = current.Next.Next;
                    current.Next.Next = temp;
                    current = current.Next.Next;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public static void ReverseAlternateNodesAndAppendAtTheEnd(this LinkedList list)
        {
            if (list.Head != null)
            {
                LinkedListNode current = list.Head;

                LinkedListNode prev = current.Next;
                current.Next = current.Next.Next;
                prev.Next = null;

                current = current.Next;

                list.Display();

                while (current != null && current.Next != null)
                {
                    LinkedListNode temp = current.Next;
                    current.Next = current.Next.Next;

                    temp.Next = prev;
                    prev = temp;

                    current = current.Next;

                    list.Display();
                }

                current.Next = prev;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="alternate"></param>
        public static void MergeAlternateNodes(this LinkedList list, LinkedList alternate)
        {
            if (list.Head != null)
            {
                LinkedListNode current1 = list.Head;
                LinkedListNode current2 = alternate.Head;

                while (current1 != null)
                {
                    LinkedListNode temp1 = current1.Next;
                    LinkedListNode temp2 = current2.Next;

                    current1.Next = current2;
                    current2.Next = temp1;

                    current2 = temp2;

                    current1 = current1.Next.Next;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public static void DeleteNAfterM(this LinkedList list, int m, int n)
        {
            if (list.Head != null)
            {
                LinkedListNode current = list.Head;
                LinkedListNode temp = new LinkedListNode();

                bool skip = true;

                int count = m - 1;

                while (current.Next != null)
                {
                    current = current.Next;

                    if (--count == 0)
                    {
                        if (skip)
                        {
                            temp = current;
                        }
                        else
                        {
                            temp.Next = current.Next;
                            current = temp;
                        }

                        count = skip ? n : m;
                        skip = !skip;
                    }
                }
            }
        }

        /// <summary>
        /// Write a program function to detect loop in a linked list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/write-a-c-function-to-detect-loop-in-a-linked-list/"/>
        public static bool HasLoop(this LinkedList list)
        {
            LinkedListNode tortoise = list.Head;
            LinkedListNode hare = list.Head;

            while (tortoise != null && hare != null && hare.Next != null)
            {
                tortoise = tortoise.Next;
                hare = hare.Next.Next;

                if (tortoise == hare)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// There are two singly linked lists in a system. By some programming error the end node of one of the linked list got linked into the second list, forming a inverted Y shaped 
        /// list. Write a program to get the point where two linked list merge.
        /// </summary>         
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/write-a-function-to-get-the-intersection-point-of-two-linked-lists/"/>
        public static LinkedListNode AreOverlappingLists(this LinkedList list1, LinkedList list2)
        {
            if (list1.Head == null || list2.Head == null)
                return null;

            LinkedListNode l = null;
            LinkedListNode s = null;

            var k = Math.Abs(list1.Count - list2.Count);

            if (list1.Count > list2.Count)
            {
                l = list1.Head;
                s = list2.Head;
            }
            else
            {
                l = list2.Head;
                s = list1.Head;
            }

            while (k-- > 0)
                l = l.Next;

            while (l != null && s != null && l.Value != s.Value)
            {
                l = l.Next;
                s = s.Next;
            }

            return l;
        }

        /// <summary>
        /// Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x
        /// </summary>
        /// <param name="list"></param>
        /// <param name="pivot"></param>      
        /// <see cref="http://qa.geeksforgeeks.org/3823/partition-the-given-linkedlist"/>
        public static void Partition(this LinkedList list, int pivot)
        {
            LinkedListNode current = list.Head;
            LinkedListNode lesser = null;
            LinkedListNode greater = null;

            while (current != null)
            {
                LinkedListNode temp = new LinkedListNode(current.Value);

                if (current.Value < pivot)
                {
                    if (lesser != null)
                        temp.Next = lesser;

                    lesser = temp;
                }
                else
                {
                    if (greater != null)
                        temp.Next = greater;

                    greater = temp;
                }

                current = current.Next;
            }

            list.Head = lesser;
            while (lesser.Next != null)
                lesser = lesser.Next;

            lesser.Next = greater;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static LinkedListNode Sum(this LinkedList a, LinkedList b)
        {
            LinkedListNode head = null;
            LinkedListNode tail = null;

            LinkedListNode currenta = a.Head;
            LinkedListNode currentb = b.Head;

            var sum = 0;
            var carry = 0;

            while (currenta != null || currentb != null)
            {
                sum = carry;

                if (currenta != null)
                {
                    sum += currenta.Value;
                    currenta = currenta.Next;
                }

                if (currentb != null)
                {
                    sum += currentb.Value;
                    currentb = currentb.Next;
                }

                var temp = sum % 10;
                carry = sum / 10;

                var node = new LinkedListNode(temp);

                if (head != null)
                {
                    tail.Next = node;
                    tail = node;
                }
                else {
                    head = node;
                    tail = node;
                }
            }

            if (carry > 0)
            {
                var node = new LinkedListNode(carry);
                tail.Next = node;
                tail = node;
            }

            return head;
        }

        //TODO: Use generic values instead of just int values
        public static BinarySearchTree<int> ToBinarySearchTree(this LinkedList list, int n)
        {
            var root = ToBinarySearchTreeNode(list, list.Count);

            return new BinarySearchTree<int>(root);
        }
        private static BinarySearchTreeNode<int> ToBinarySearchTreeNode(LinkedList list, int n)
        {
            if (n <= 0)
                return null;

            BinarySearchTreeNode<int> left = ToBinarySearchTreeNode(list, n / 2);

            BinarySearchTreeNode<int> root = new BinarySearchTreeNode<int>(list.Head.Value);
            root.Left = left;

            list.Head = list.Head.Next;

            BinarySearchTreeNode<int> right = ToBinarySearchTreeNode(list, n - n / 2 - 1);
            root.Right = right;

            return root;

        }
    }
}