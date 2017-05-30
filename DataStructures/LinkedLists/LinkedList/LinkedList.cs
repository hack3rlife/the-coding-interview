using System;
using System.Collections;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// In computer science, a linked list is a linear collection of data elements, called nodes pointing to the next node by means of a pointer. It is a data structure consisting of a 
    /// group of nodes which together represent a sequence. Under the simplest form, each node is composed of data and a reference (in other words, a link) to the next node in the sequence;
    /// more complex variants add additional links. This structure allows for efficient insertion or removal of elements from any position in the sequence.
    /// </summary>
    /// <typeparam name="int"></typeparam>
    /// <see cref="https://en.wikipedia.org/wiki/Linked_list"/>
    public class LinkedList : ICollection<int>
    {
        /// <summary>
        /// Gets the first node of the LinkedList.
        /// </summary>
        public LinkedListNode Tail { get; set; }

        /// <summary>
        /// Gets the last node of the LinkedList.
        /// </summary>
        public LinkedListNode Head { get; set; }

        /// <summary>
        /// Gets the number of nodes actually contained in the LinkedList
        /// </summary>
        public int Count { get; set; }

        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Adds a new node containing the specified value at the start of the LinkedList.
        /// </summary>
        /// <param name="value">The value to add at the start of the LinkedList.</param>
        public void AddFirst(int value)
        {
            LinkedListNode node = new LinkedListNode(value);

            if (this.Head != null)
            {
                node.Next = this.Head;
                this.Head = node;
            }
            else
            {
                this.Head = node;
                this.Tail = node;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds a new node containing the specified value at the end of the LinkedList.
        /// </summary>
        /// <param name="value">The value to add at the end of the LinkedList.</param>
        public void AddLast(int value)
        {
            LinkedListNode node = new LinkedListNode(value);

            if (this.Head != null)
            {
                this.Tail.Next = node;
                this.Tail = node;
            }
            else
            {
                this.Head = node;
                this.Tail = node;
            }

            this.Count++;
        }

        /// <summary>
        /// Removes the node at the start of the LinkedList.
        /// </summary>
        public void RemoveFirst()
        {
            if (this.Head != null)
            {
                if (this.Count == 1)
                {
                    this.Head = null;
                    this.Tail = null;
                }
                else if (this.Count == 2)
                {
                    this.Head = this.Tail;
                }
                else if (this.Count >= 3)
                {
                    LinkedListNode current = this.Head.Next;
                    this.Head = current;
                }

                this.Count--;
            }
        }

        /// <summary>
        /// Removes the node at the end of the LinkedList.
        /// </summary>
        public void RemoveLast()
        {
            if (this.Head != null)
            {
                if (this.Count == 1)
                {
                    this.Head = null;
                    this.Tail = null;
                }
                else if (this.Count == 2)
                {
                    this.Tail = this.Head;
                }
                else if (this.Count >= 3)
                {
                    LinkedListNode current = this.Head;

                    while (current.Next.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = null;

                    this.Tail = current;
                }

                this.Count--;
            }
        }

        /// <summary>
        /// Removes the first occurrence of the <para>value</para>
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true if the value was found and remove; otherwise null</returns>
        public bool Remove(int value)
        {
            if (this.Head != null)
            {
                LinkedListNode current = this.Head;
                LinkedListNode previous = null;

                while (current != null)
                {
                    if (current.Value == value)
                    {
                        if (previous == null)
                        {
                            this.Head = current.Next;

                            if (this.Head == null)
                                this.Tail = null;
                        }
                        else
                        {
                            previous.Next = current.Next;

                            if (current.Next == null)
                                this.Tail = previous;
                        }

                        this.Count--;

                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            return false;
        }

        /// <summary>
        /// Removes all the duplicates
        /// </summary>
        /// <typeparam name="int"></typeparam>
        /// <param name="data"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public LinkedListNode RemoveAll(int data, LinkedListNode current)
        {
            if (current == null)
                return current;

            if (current.Value == data)
            {
                return RemoveAll(data, current.Next);
            }
            else
            {
                current.Next = RemoveAll(data, current.Next);
                return current;
            }
        }

        /// <summary>
        /// Print the nodes of the LinkedList
        /// </summary>        
        public void Display()
        {
            LinkedListNode node = this.Head;

            while (node != null)
            {
#if DEBUG
                System.Diagnostics.Debug.Write(string.Format("|{0}||->", node.Value));
#endif
                Console.Write(string.Format("|{0}||->", node.Value));
                node = node.Next;
            }

#if DEBUG
            System.Diagnostics.Debug.WriteLine("");
#endif
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            this.Tail = null;
            this.Head = null;
            this.Count = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(int item)
        {
            LinkedListNode current = this.Head;

            while (current != null)
            {
                if (current.Value == item)
                    return true;

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            LinkedListNode current = this.Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return ((IEnumerable<int>)this).GetEnumerator();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void ICollection<int>.Add(int item)
        {
            this.AddLast(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        void ICollection<int>.CopyTo(int[] array, int arrayIndex)
        {
            LinkedListNode current = this.Head;

            while (current != null && arrayIndex <= array.Length - 1)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }
    }
}
