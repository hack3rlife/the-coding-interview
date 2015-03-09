using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class LinkedListExtension
    {
        /// <summary>
        /// Finds and returns the Node<T> which is the nth position of the LinkedList<T> 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static Node<T> FindNTh<T>(this LinkedList.LinkedList<T> list, int position)
        {
            if (list.Head != null)
            {
                Node<T> current = list.Head;

                for (int i = 0; i < position; i++)
                {
                    if (current != null)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("The Linked List has no more elements");
                    }
                }

                Node<T> nth = list.Head;

                while (current != null)
                {
                    nth = nth.Next;
                }

                return nth;
            }

            return null;
        }

        public static Node<T> Findnth<T>(this LinkedList.LinkedList<T> list, int position)
        {
            if (list.Head != null)
            {
                Node<T> current = list.Head;
                Node<T> nth = list.Head;

                while (current != null)
                {
                    if (position-- <= 0)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        current = current.Next;
                        nth = nth.Next;
                    }
                }

                return position == 0 ? nth : null;
            }

            return null;
        }

        /// <summary>
        /// Reverse a LinkedList<T> (Iterative version)
        /// </summary>
        public static void Reverse<T>(this LinkedList.LinkedList<T> list)
        {
            if (list.Head != null)
            {
                Node<T> previous = null;
                Node<T> current = list.Head;
                Node<T> next = null;

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
        /// Reverse a LinkedList<T> (Recursive version)
        /// </summary>
        /// <param name="list"></param>
        /// <param name="current"></param>
        public static void Reverse<T>(this LinkedList.LinkedList<T> list, Node<T> current)
        {
            if (current.Next == null)
            {
                list.Head = current;
                return;
            }

            Reverse(list, current.Next);

            Node<T> node = current.Next;
            current.Next = null;
            node.Next = current;
        }

        /// <summary>
        /// Remove duplicates from an unsorted LinkedList<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void RemoveDulicatesUnsorted<T>(this LinkedList.LinkedList<T> list)
        {
            if (list.Head != null)
            {
                Node<T> current = list.Head;

                while (current != null)
                {
                    Node<T> node = current.Next;

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
        /// Remove duplicates from an sorted LinkedList<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void RemoveDuplicatesSorted<T>(this LinkedList.LinkedList<T> list)
        {
            if (list.Head != null)
            {
                Node<T> current = list.Head;

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
        /// <param name="list">LinkedList<T></param>
        /// <param name="k">Number of times the LinkedList is going to be rotated</param>
        public static void Rotate<T>(this LinkedList.LinkedList<T> list, int k)
        {
            if (list.Head == null)
                return;

            if (list.Count < k)
                return;

            Node<T> current = list.Head;
            Node<T> kthnode = null;

            while (current.Next != null)
            {
                if (k == 1)
                {
                    kthnode = current;
                }

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
        public static void SwapConsecutives<T>(this LinkedList.LinkedList<T> list)
        {
            if (list.Head != null && list.Head.Next != null)
            {
                Node<T> current = list.Head;
                list.Head = current.Next;
                current.Next = list.Head.Next;
                list.Head.Next = current;

                while (current.Next != null && current.Next.Next != null)
                {
                    Node<T> temp = current.Next;
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
        public static void ReverseAlternateNodesAndAppendAtTheEnd<T>(this LinkedList.LinkedList<T> list)
        {
            if (list.Head != null)
            {
                Node<T> current = list.Head;

                Node<T> prev = current.Next;
                current.Next = current.Next.Next;
                prev.Next = null;

                current = current.Next;

                list.Display();

                while (current != null && current.Next != null)
                {
                    Node<T> temp = current.Next;
                    current.Next = current.Next.Next;

                    temp.Next = prev;
                    prev = temp;

                    current = current.Next;

                    list.Display();
                }

                current.Next = prev;
            }
        }

        public static void MergeAlternateNodes<T>(this LinkedList.LinkedList<T> list, LinkedList.LinkedList<T> alternate)
        {
            if (list.Head != null)
            {
                Node<T> current1 = list.Head;
                Node<T> current2 = alternate.Head;

                while (current1 != null)
                {
                    Node<T> temp1 = current1.Next;
                    Node<T> temp2 = current2.Next;

                    current1.Next = current2;
                    current2.Next = temp1;

                    current2 = temp2;

                    current1 = current1.Next.Next;
                }
            }
        }

        public static void DeleteNAfterM<T>(this LinkedList.LinkedList<T> list, int m, int n)
        {
            if (list.Head != null)
            {
                Node<T> current = list.Head;
                Node<T> temp = new Node<T>();

                bool skip = true;

                int count = m-1;

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
    }
}