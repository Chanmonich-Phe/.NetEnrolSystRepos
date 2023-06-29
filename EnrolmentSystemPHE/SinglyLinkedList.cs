using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
    public class LinkedListNode<T>
    {
        // Represents a node in the linked list
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }


        public LinkedListNode<T> Next // Represents a node in the linked list
        {
            get;
            set;
        }

        public LinkedListNode<T> Previous // Represents a node in the linked list
        {
            get;
            set;
        }
    }

    public class SinglyLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
        public int Count // Number of elements in the linked list
        {
            get;
            set;
        }

        public LinkedListNode<T> Head // Reference to the first node
        {
            get;
            set;
        }

        public LinkedListNode<T> Tail // Reference to the last node

        {
            get;
            set;
        }

        public void AddFirst(T value) // Adds a new node with the specified value at the beginning of the linked list
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node) // Adds the given node at the beginning of the linked list
        {
            LinkedListNode<T> temp = Head;

            Head = node;

            Head.Next = temp;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value) // Adds a new node with the specified value at the end of the linked list
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node) // Adds a new node with the specified value at the end of the linked list
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst() // Adds a new node with the specified value at the end of the linked list
        {
            if (Head != null)
            {
                // Adds a new node with the specified value at the end of the linked list
                if (Head.Next == null)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
                Count--;
            }
        }


        public void RemoveLast() // Removes the last node from the linked list
        {
            if (Count != 0)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                LinkedListNode<T> current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }
            Count--;
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)  // Removes the last node from the linked list
        {
            AddFirst(item);
        }

        public void Clear() // Clears the linked list by setting Head and Tail to null and count to 0
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item) // Checks if the linked list contains the specified item
        {
            LinkedListNode<T> current = Head;
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

        public void CopyTo(T[] array, int arrayIndex) // Checks if the linked list contains the specified item
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item) // Checks if the linked list contains the specified item
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

    //    public LinkedListNode<T> Next { get; private set; }

    //    public LinkedListNode<T> Head { get; private set; }

    //    public LinkedListNode<T> Tail { get; private set; }

    //    private void AddFirst(T value)
    //    {
    //        AddFirst(new LinkedListNode<T>(value));
    //    }

    //    public void AddFirst(LinkedListNode<T> node)
    //    {

    //        LinkedListNode<T> temp = Head;

    //        Head = node;
    //        Head.Next = temp;
    //        Count++;
    //        if (Count == 1)
    //        {
    //            Tail = Head;
    //        }
    //    }

    //    public void AddLast(T value)
    //    {
    //        AddLast(new LinkedListNode<T>(value));
    //    }

    //    public void AddLast(LinkedListNode<T> node)
    //    {
    //        if (Count == 0)
    //        {
    //            Head = node;
    //        }

    //        else
    //        {
    //            Tail.Next = node;
    //        }
    //        Tail = node;
    //        Count++;
    //    }


    //    public void RemoveFirst()
    //    {
    //        if (Count != 0)
    //        {
    //            Head = Head.Next;
    //            Count--;

    //            if (Count == 0)
    //            {
    //                Tail = null;
    //            }
    //        }
    //    }

    //    public void RemoveLast()
    //    {
    //        if (Count != 0)
    //        {
    //            if (Count == 1)
    //            {
    //                Head = null;
    //                Tail = null;
    //            }
    //            else
    //            {
    //                LinkedListNode<T> current = Head;
    //                while (current.Next != Tail)
    //                {
    //                    current = current.Next;
    //                }
    //                current.Next = null;
    //                Tail = current;
    //            }
    //        }
    //    }

    //    public int Count
    //    {
    //        get;
    //        private set;
    //    }

    //    public bool IsReadOnly => throw new NotImplementedException();

    //    public void Add(T item)
    //    {
    //        AddFirst(item);
    //    }


    //    public bool Contains(T item)
    //    {
    //        LinkedListNode<T> current = Head;
    //        while (current != null)
    //        {
    //            if (current.Value.Equals(item))
    //            {
    //                return true;
    //            }
    //            current = current.Next;
    //        }
    //        return false;
    //    }

    //    public bool Remove(T item)
    //    {
    //        LinkedListNode<T> previous = null;
    //        LinkedListNode<T> current = Head;

    //        while (current != null)
    //        {
    //            if (current.Value.Equals(item))
    //            {
    //                if (previous != null)
    //                {
    //                    previous.Next = current.Next;
    //                    if (current.Next == null)
    //                    {
    //                        Tail = previous;
    //                    }
    //                    Count--;
    //                }
    //                else
    //                {
    //                    RemoveFirst();
    //                }
    //                return true;
    //            }
    //            previous = current;
    //            current = current.Next;
    //        }
    //        return false;
    //    }

    //    public void CopyTo(T[] array, int arrayIndex)
    //    {
    //        LinkedListNode<T> current = Head;
    //        while (current != null)
    //        {
    //            array[arrayIndex++] = current.Value;
    //            current = current.Next;
    //        }
    //    }

    //    public void Clear()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

