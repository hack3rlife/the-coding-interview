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
    }
}
