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
    }
}
