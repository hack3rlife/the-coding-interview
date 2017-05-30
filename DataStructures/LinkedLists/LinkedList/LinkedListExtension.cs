using System;
using System.Collections;

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
        /// <![CDATA[
        /// Input : Head of following linked list: 1->2->3->4->NULL
        /// Output : Linked list should be changed to: 4->3->2->1->NULL
        /// ]]>
        /// <param name="list">The <see cref="LinkedList{T}"/> </param>
        /// <see cref="http://www.geeksforgeeks.org/write-a-function-to-reverse-the-nodes-of-a-linked-list/"/>
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
        /// Remove duplicates from an unsorted LinkedList: deletes any duplicate nodes from the list. The list is not sorted.
        /// </summary>
        /// <![CDATA[
        /// For example if the linked list is 12->11->12->21->41->43->21 then removeDuplicates() should convert the list to 12->11->21->41->43.
        /// ]]>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <see cref="http://www.geeksforgeeks.org/remove-duplicates-from-an-unsorted-linked-list/"/>
        public static LinkedList RemoveDulicatesUnsorted(this LinkedList list)
        {
            if (list == null)
                return null;

            LinkedListNode curr = list.Head;
            LinkedListNode prev = null;
            Hashtable ht = new Hashtable();

            while (curr != null)
            {
                if (ht.ContainsKey(curr.Value))
                {
                    prev.Next = curr.Next;
                    list.Count--;
                }
                else
                {
                    ht.Add(curr.Value, 1);
                    prev = curr;
                }

                curr = prev.Next;
            }

            return list;
        }

        /// <summary>
        /// Remove duplicates from an sorted LinkedList in non-decreasing order and deletes any duplicate nodes from the list
        /// </summary>
        /// <![CDATA[
        /// For example if the linked list is 11->11->11->21->43->43->60 then removeDuplicates() should convert the list to 11->21->43->60.
        /// ]]>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <see cref="http://www.geeksforgeeks.org/remove-duplicates-from-a-sorted-linked-list/"/>
        public static LinkedList RemoveDuplicatesSorted(this LinkedList list)
        {
            if (list == null)
                return null;

            LinkedListNode current = list.Head;
            LinkedListNode next = null;

            while (current.Next != null)
            {
                if (current.Value.Equals(current.Next.Value))
                {
                    next = current.Next.Next;
                    list.Count--;
                    current.Next = next;
                }
                else
                {
                    current = current.Next;
                }
            }

            return list;
        }

        /// <summary>
        /// Given a singly linked list, rotate the linked list counter-clockwise by k nodes
        /// </summary>
        /// <![CDATA[
        /// For example, if the given linked list is 10->20->30->40->50->60 and k is 4, the list should be modified to 50->60->10->20->30->40. Assume that k is smaller than the count of 
        /// nodes in linked list.
        /// ]]>
        /// <param name="list">The <see cref="LinkedList"/></param>
        /// <param name="k">Number of times the LinkedList is going to be rotated</param>
        /// <see cref="http://www.geeksforgeeks.org/rotate-a-linked-list/"/>
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
            list.Tail = kthnode;

        }

        /// <summary>
        /// Pairwise swap elements of a given linked list
        /// </summary>
        /// <![CDATA[
        /// Given a singly linked list, write a function to swap elements pairwise. For example, if the linked list is 1->2->3->4->5 then the function should change it to 2->1->4->3->5,
        /// and if the linked list is 1->2->3->4->5->6 then the function should change it to 2->1->4->3->6->5.
        /// ]]>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The <see cref="LinkedList"/></param>
        /// <see cref="http://www.geeksforgeeks.org/pairwise-swap-elements-of-a-given-linked-list/"/>
        public static void SwapConsecutives(this LinkedList list)
        {
            if (list == null && list.Head == null)
                return;

            var prev = list.Head;
            var curr = list.Head.Next;

            list.Head = curr;

            while (true)
            {
                var next = curr.Next;
                curr.Next = prev;

                if (next == null || next.Next == null)
                {
                    prev.Next = next;
                    break;
                }

                prev.Next = next.Next;

                prev = next;
                curr = prev.Next;
            }

        }

        /// <summary>
        /// Given a linked list, reverse alternate nodes and append at the end
        /// </summary>
        /// <![CDATA[
        /// Given a linked list, reverse alternate nodes and append them to end of list.
        /// Examples
        ///         Input List:  1->2->3->4->5->6
        ///         Output List: 1->3->5->6->4->2
        /// 
        ///         Input List:  12->14->16->18->20
        ///         Output List: 12->16->20->18->14
        /// ]]>
        /// <param name="list"></param>
        /// <see cref="http://www.geeksforgeeks.org/given-linked-list-reverse-alternate-nodes-append-end/"/>
        public static void ReverseAlternateNodesAndAppendAtTheEnd(this LinkedList list)
        {
            //if head is null or list is less than 3 nodes
            if (list.Head == null || list.Head.Next == null && list.Head.Next.Next == null)
            {
                return;
            }

            var odd = list.Head;
            var even = odd.Next;

            odd.Next = odd.Next.Next;
            odd = odd.Next;
            even.Next = null;

            while (odd != null && odd.Next != null)
            {
                var temp = odd.Next.Next;
                odd.Next.Next = even;
                even = odd.Next;
                odd.Next = temp;

                if (temp != null)
                    odd = temp;
            }

            odd.Next = even;

        }

        /// <summary>
        /// Merge a linked list into another linked list at alternate positions
        /// </summary>
        /// <![CDATA[
        /// Given two linked lists, insert nodes of second list into first list at alternate positions of first list. 
        /// For example, if first list is 5->7->17->13->11 and second is 12->10->2->4->6, the first list should become 5->12->7->10->17->2->13->4->11->6 and second list should become empty.
        /// The nodes of second list should only be inserted when there are positions available.For example, if the first list is 1->2->3 and second list is 4->5->6->7->8, then first list 
        /// should become 1->4->2->5->3->6 and second list to 7-> 8.
        /// ]]>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="alternate"></param>
        /// <see cref="http://www.geeksforgeeks.org/merge-a-linked-list-into-another-linked-list-at-alternate-positions/"/>
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

                alternate.Head = current2;
            }
        }

        /// <summary>
        /// Delete N nodes after M nodes of a linked list
        /// </summary>
        /// <![CDATA[
        /// Given a linked list and two integers M and N. Traverse the linked list such that you retain M nodes then delete next N nodes, continue the same till end of the linked list.
        /// 
        /// Input:
        ///        M = 2, N = 2
        ///        Linked List: 1->2->3->4->5->6->7->8
        ///        Output:
        ///        Linked List: 1->2->5->6
        /// Input:
        ///        M = 3, N = 2
        ///        Linked List: 1->2->3->4->5->6->7->8->9->10
        ///        Output:
        ///        Linked List: 1->2->3->6->7->8
        /// ]]>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <see cref="http://www.geeksforgeeks.org/delete-n-nodes-after-m-nodes-of-a-linked-list/"/>
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
        /// Partitioning a linked list around a given value and keeping the original order.
        /// </summary>
        /// <![CDATA[
        /// Given a linked list and a value x, partition it such that all nodes less than x come first, then all nodes with value equal to x and finally nodes with value greater than or 
        /// equal to x. The original relative order of the nodes in each of the three partitions should be preserved. The partition must work in-place.
        /// 
        /// Examples:
        /// 
        ///         Input : 1->4->3->2->5->2->3, 
        ///         x = 3
        ///         Output: 1->2->2->3->3->4->5
        /// 
        ///         Input : 1->4->2->10 
        ///         x = 3
        ///         Output: 1->2->4->10
        /// 
        ///         Input : 10->4->20->10->3 
        ///         x = 3
        ///         Output: 3->10->4->20->10 
        /// ]]>
        /// <param name="list"></param>
        /// <param name="pivot"></param>      
        /// <see cref="http://qa.geeksforgeeks.org/3823/partition-the-given-linkedlist"/>
        public static void Partition(this LinkedList list, int pivot)
        {
            //TODO: This method is incomplet and not working
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
        /// Add two numbers represented by linked lists
        /// </summary>
        /// <![CDATA[
        /// Given two numbers represented by two lists, write a function that returns sum list. The sum list is list representation of addition of two input numbers.
        /// Input:
        ///        First List: 5->6->3  // represents number 365
        ///        Second List: 8->4->2 //  represents number 248
        ///        Output
        ///        Resultant list: 3->1->6  // represents number 613
        /// ]]>
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
                else
                {
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