using System;
using System.Collections;
using System.Collections.Generic;

namespace com.hack3rlife.datastructures
{
    /// <summary>
    /// Represents a Single Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : ICollection<T>
    {
        /// <summary>
        /// Gets the first node of the LinkedList<T>.
        /// </summary>
        public LinkedListNode<T> Tail { get; internal set; }

        /// <summary>
        /// Gets the last node of the LinkedList<T>.
        /// </summary>
        public LinkedListNode<T> Head { get; set; }

        /// <summary>
        /// Gets the number of nodes actually contained in the LinkedList<T>
        /// </summary>
        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Adds a new node containing the specified value at the start of the LinkedList<T>.
        /// </summary>
        /// <param name="value">The value to add at the start of the LinkedList<T>.</param>
        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

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
        /// Adds a new node containing the specified value at the end of the LinkedList<T>.
        /// </summary>
        /// <param name="value">The value to add at the end of the LinkedList<T>.</param>
        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

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
        /// Removes the node at the start of the LinkedList<T>.
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
                else if(this.Count>=3)
                {
                    LinkedListNode<T> current = this.Head.Next;
                    this.Head = current;
                }

                this.Count--;
            }
        }

        /// <summary>
        /// Removes the node at the end of the LinkedList<T>.
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
                else if (this.Count>=3)
                {
                    LinkedListNode<T> current = this.Head;

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
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Remove(T value)
        {
            if (this.Head != null)
            {
                LinkedListNode<T> current = this.Head;
                LinkedListNode<T> previous = null;

                while (current != null)
                {
                    if (current.Value.Equals(value))
                    {
                        if (previous == null)
                        {
                            this.Head = current.Next;

                            if (this.Head == null)
                            {
                                this.Tail = null;
                            }
                        }
                        else
                        {
                            previous.Next = current.Next;

                            if (current.Next == null)
                            {
                                this.Tail = previous;
                            }
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
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public LinkedListNode<T> Remove(int data, LinkedListNode<T> current)
        {
            if (data == null)
                return current;
            if (current == null || current.Next == null)
                return current;

            if (current.Value.Equals(data))
            {
                return Remove(data, current.Next);
            }
            else
            {
                current.Next = Remove(data, current.Next);
                return current;
            }
        }

        /// <summary>
        /// Print the nodes of the LinkedList
        /// </summary>        
        public void Display()
        {
            LinkedListNode<T> node = this.Head;

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
        public bool Contains(T item)
        {
            LinkedListNode<T> current = this.Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            LinkedListNode<T> current = this.Head;

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
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void ICollection<T>.Add(T item)
        {
            this.AddLast(item);
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = this.Head;

            while (current != null && arrayIndex <= array.Length - 1)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }        
    }
}
